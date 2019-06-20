using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CharacterCreationEngine.Characteristics;

namespace CharacterCreationEngine
{
    /// <summary>
    /// Creator class for all Creature-type objects.
    /// </summary>
    [DataContract, 
        KnownType(typeof(Human)),
        KnownType(typeof(Elf)),
        KnownType(typeof(Dwarf)),
        KnownType(typeof(Halfling)),
        KnownType(typeof(Gnome))]
    public abstract class Creature
    {
        //private dictionary for holding Characteristic types as values, organized by string-type keys
        private Dictionary<string, Characteristic> _characteristicsDictionary = new Dictionary<string, Characteristic>();

        //constructor calls Factory method
        public Creature()
        {
            CreatureGUID = Guid.NewGuid();
            BuildCharacteristics();
        }

        //indexer for dictionary of characteristics
        public Characteristic this[string key]
        {
            get { return _characteristicsDictionary[key]; }
            set { _characteristicsDictionary[key] = value; }
        }

        //returns the dictionary of characteristics
        //if null, creates new dictionary
        [DataMember]
        public Dictionary<string, Characteristic> CharacteristicDictionary
        { get { return _characteristicsDictionary ?? (_characteristicsDictionary = new Dictionary<string, Characteristic>()); } }
        
        [DataMember]
        public Guid CreatureGUID { get; set; }

        //Factory method to be overriden by concrete creator classes
        public abstract void BuildCharacteristics();

        /// <summary>
        /// Given a Guid object, this method is used to set the Guid of a Creature object.
        /// </summary>
        /// <param name="guid"></param>
        public void SetCreatureGUID(Guid guid)
        {
            if (!string.IsNullOrEmpty(guid.ToString()))
            {
                CreatureGUID = guid;
            }
        }

        /// <summary>
        /// Gets a Creature object's Guid as a string.
        /// </summary>
        /// <returns></returns>
        public string GetCreatureGUIDAsString()
        {
            return CreatureGUID.ToString("D");
        }
    }
}
