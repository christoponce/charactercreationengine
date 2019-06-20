using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

//This is a separate namespace from "CharacterCreationEngine" to make DataContract saving more dynamic
namespace CharacterCreationEngine
{
    namespace Characteristics
    {
        //Containment file for all creature characteristic classes
        [DataContract, KnownType(typeof(Characteristic))]
        public abstract class Characteristic { }

        #region CharacteristicClasses
        /// <summary>
        /// Characteristic class for the Subrace value. Constructor takes a string to set the Subrace property.
        /// </summary>
        [DataContract]
        public class CharaSubrace : Characteristic
        {
            public CharaSubrace(string subrace)
            {
                Subrace = subrace;
            }

            [DataMember]
            public string Subrace { get; set; }

            public override string ToString() => $"{Subrace}";
        }

        /// <summary>
        /// Characteristic class for the FirstName value. Constructor takes a string to set the FirstName property.
        /// </summary>
        [DataContract]
        public class CharaFirstName : Characteristic
        {
            public CharaFirstName(string firstName)
            {
                FirstName = firstName;
            }

            [DataMember]
            public string FirstName { get; set; }

            public override string ToString() => $"{FirstName}";
        }

        /// <summary>
        /// Characteristic class for the Surname value. Constructor takes a string to set the Surname property.
        /// </summary>
        [DataContract]
        public class CharaSurname : Characteristic
        {
            public CharaSurname(string surname)
            {
                Surname = surname;
            }

            [DataMember]
            public string Surname { get; set; }

            public override string ToString() => $"{Surname}";
        }

        /// <summary>
        /// Characteristic class for the Height value. Constructor takes an int to set the Height property.
        /// </summary>
        [DataContract]
        public class CharaHeight : Characteristic
        {
            public CharaHeight(int height)
            {
                Height = height;
            }

            [DataMember]
            public int Height { get; set; }

            public override string ToString() => $"{Height}";
        }

        /// <summary>
        /// Characteristic class for the Weight value. Constructor takes an int to set the Weight property.
        /// </summary>
        [DataContract]
        public class CharaWeight : Characteristic
        {
            public CharaWeight(int weight)
            {
                Weight = weight;
            }

            [DataMember]
            public int Weight { get; set; }

            public override string ToString() => $"{Weight}";
        }

        /// <summary>
        /// Characteristic class for the Age value. Constructor takes an int to set the Age property.
        /// </summary>
        [DataContract]
        public class CharaAge : Characteristic
        {
            public CharaAge(int age)
            {
                Age = age;
            }

            [DataMember]
            public int Age { get; set; }

            public override string ToString() => $"{Age}";
        }

        /// <summary>
        /// Characteristic class for the Description value. Constructor takes a string to set the Description property.
        /// </summary>
        [DataContract]
        public class CharaDescription : Characteristic
        {
            public CharaDescription(string description)
            {
                Description = description;
            }

            [DataMember]
            public string Description { get; set; }

            public override string ToString() => $"{Description}";
        }

        /// <summary>
        /// Characteristic class for the Language value. Constructor takes an optional string to set the BaseLanguage property.
        /// The BaseLanguage will be set to "Common Tongue" if no alternative is provided.
        /// Further additional languages can be added to this class' internal list via the "AddLanguage" extension method.
        /// This internal list is always populated with at least the BaseLanguage value and can be retrieved via the "GetLanguageList" extension method.
        /// </summary>
        [DataContract]
        public class CharaLanguage : Characteristic
        {
            private List<string> _languages = new List<string>();
            private string _baseLanguage;

            public CharaLanguage(string baseLanguage = "Common Tongue")
            {
                BaseLanguage = baseLanguage;
                AddLanguage(baseLanguage);
            }

            [DataMember]
            public string BaseLanguage
            {
                get
                {
                    if (_baseLanguage == null)
                    {
                        _baseLanguage = "Common Tongue";
                    }

                    return _baseLanguage;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        _baseLanguage = value;
                    }
                }
            }

            [DataMember]
            public List<string> Languages
            {
                get
                {
                    return _languages ?? (_languages = new List<string>());
                }
            }

            public void AddLanguage(string language)
            {
                if (!string.IsNullOrEmpty(language))
                {
                    _languages.Add(language);
                }
            }

            public override string ToString() => $"{BaseLanguage}";
        }

        /// <summary>
        /// Characteristic class for the Race value. Constructor takes a Race enum value to set the Race property.
        /// </summary>
        [DataContract]
        public class CharaRace : Characteristic
        {
            public CharaRace(Race race)
            {
                Race = race;
            }

            [DataMember]
            public Race Race { get; set; }

            public override string ToString() => $"{Race}";
        }

        /// <summary>
        /// Characteristic class for the RelativeSize value. Constructor takes a RelativeSize enum value to set the RelativeSize property.
        /// </summary>
        [DataContract]
        public class CharaRelativeSize : Characteristic
        {
            public CharaRelativeSize(RelativeSize relativeSize)
            {
                RelativeSize = relativeSize;
            }

            [DataMember]
            public RelativeSize RelativeSize { get; set; }

            public override string ToString() => $"{RelativeSize}";
        }

        /// <summary>
        /// Characteristic class for the Gender value. Constructor takes a Gender enum value to set the Gender property.
        /// </summary>
        [DataContract]
        public class CharaGender : Characteristic
        {
            public CharaGender(Gender gender)
            {
                Gender = gender;
            }

            [DataMember]
            public Gender Gender { get; set; }

            public override string ToString() => $"{Gender}";
        }

        /// <summary>
        /// Characteristic class for the CreatureType value. Constructor takes a CreatureType enum value to set the CreatureType property.
        /// </summary>
        [DataContract]
        public class CharaCreatureType : Characteristic
        {
            public CharaCreatureType(CreatureType creatureType)
            {
                CreatureType = creatureType;
            }

            [DataMember]
            public CreatureType CreatureType { get; set; }

            public override string ToString() => $"{CreatureType}";
        }

        /// <summary>
        /// Characteristic class for the Diet value. Constructor takes a Diet enum value to set the Diet property.
        /// </summary>
        [DataContract]
        public class CharaDiet : Characteristic
        {
            public CharaDiet(Diet diet)
            {

                Diet = diet;
            }

            [DataMember]
            public Diet Diet { get; set; }

            public override string ToString() => $"{Diet}";
        }

        /// <summary>
        /// Characteristic class for the Alignment value. Constructor takes an Aignment enum value to set the Alignment property.
        /// </summary>
        [DataContract]
        public class CharaAlignment : Characteristic
        {
            public CharaAlignment(Alignment alignment)
            {
                Alignment = alignment;
            }

            [DataMember]
            public Alignment Alignment { get; set; }

            public override string ToString() => $"{Alignment}";
        }

        /// <summary>
        /// Characteristic class for the Tail value. Constructor takes a Tail enum value to set the Tail property.
        /// </summary>
        [DataContract]
        public class CharaTail : Characteristic
        {
            public CharaTail(Tail tail)
            {
                Tail = tail;
            }

            [DataMember]
            public Tail Tail { get; set; }

            public override string ToString() => $"{Tail}";
        }

        /// <summary>
        /// Characteristic class for the CombatClass value. Constructor takes a CombatClass enum value to set the CombatClass property.
        /// </summary>
        [DataContract]
        public class CharaCombatClass : Characteristic
        {
            public CharaCombatClass(CombatClass combatClass)
            {
                CombatClass = combatClass;
            }

            [DataMember]
            public CombatClass CombatClass { get; set; }

            public override string ToString() => $"{CombatClass}";
        }

        /// <summary>
        /// Characteristic class for the LifeStage value. Constructor takes a LifeStage enum value to set the LifeStage property.
        /// </summary>
        [DataContract]
        public class CharaLifeStage : Characteristic
        {
            public CharaLifeStage(LifeStage lifeStage)
            {
                LifeStage = lifeStage;
            }

            [DataMember]
            public LifeStage LifeStage { get; set; }

            public override string ToString() => $"{LifeStage}";
        }

        /// <summary>
        /// Characteristic class for the Background value. Constructor takes a Background enum value to set the Background property.
        /// </summary>
        [DataContract]
        public class CharaBackground : Characteristic
        {
            public CharaBackground(Background background)
            {
                Background = background;
            }

            [DataMember]
            public Background Background { get; set; }

            public override string ToString() => $"{Background}";
        }

        /// <summary>
        /// Characteristic class for the Wings value. Constructor takes a Wings enum value to set the Wings property.
        /// </summary>
        [DataContract]
        public class CharaWings : Characteristic
        {
            public CharaWings(Wings wings)
            {
                Wings = wings;
            }

            public Wings Wings { get; set; }

            public override string ToString() => $"{Wings}";
        }

        /// <summary>
        /// Characteristic class for tracking a character's various Stats.
        /// </summary>
        [DataContract]
        public class CharaStatistic : Characteristic
        {
            //private instance variables / property backing fields
            //cannot be initialized here, else stackoverflow exception occurs
            private BindingList<string> _proficiencies;
            private Dictionary<Skills, int> _skills;
            private Dictionary<string, int> _equipment;
            //private Statistic _stats;

            //empty contructor
            public CharaStatistic() { }

            [DataMember]
            public int ArmorClass { get; set; }

            [DataMember]
            public int Initiative { get; set; }

            [DataMember]
            public int Speed { get; set; }

            [DataMember]
            public int Strength { get; set; }

            [DataMember]
            public int Intelligence { get; set; }

            [DataMember]
            public int Dexterity { get; set; }

            [DataMember]
            public int Constitution { get; set; }

            [DataMember]
            public int Wisdom { get; set; }

            [DataMember]
            public int Charisma { get; set; }

            [DataMember]
            public string PersonalityTraits { get; set; }

            [DataMember]
            public string Ideals { get; set; }

            [DataMember]
            public string Bonds { get; set; }

            [DataMember]
            public string Flaws { get; set; }

            [DataMember]
            public int PassiveWisdom { get; set; }

            //tracks a character's proficiencies
            //returns the backing field or a new List<string> if the backing field is null
            [DataMember]
            public BindingList<string> Proficiencies
            { get { return _proficiencies ?? (_proficiencies = new BindingList<string>()); } }

            //tracks a character's skills and how good they are at said skills
            //returns the backing field or a new Dictionary<Skills, int> if the backing field is null
            [DataMember]
            public Dictionary<Skills, int> Skills
            { get { return _skills ?? (_skills = new Dictionary<Skills, int>()); } }

            //tracks a character's equipment and how much said equipment weighs, in pounds
            //returns the backing field or a new Dictionary<string, int> if the backing field is null
            [DataMember]
            public Dictionary<string, int> Equipment
            { get { return _equipment ?? (_equipment = new Dictionary<string, int>()); } }

            /// <summary>
            /// Adds a proficiency to the List of proficiencies for this object.
            /// </summary>
            /// <param name="proficiency"></param>
            public void AddProficiency(string proficiency)
            {
                if (!string.IsNullOrEmpty(proficiency) && Proficiencies != null)
                {
                    Proficiencies.Add(proficiency);

                    return;
                }

                throw new ArgumentNullException(nameof(proficiency),
                                                $"{nameof(Proficiencies)} cannot have an empty or null value assigned to it. Alternatively, " +
                                                $"{nameof(Proficiencies)} itself cannot be null when assigning a value to it.");
            }

            /// <summary>
            /// Adds a Skill to the Dictionary that tracks this object's skills.
            /// </summary>
            /// <param name="skill"></param>
            /// <param name="skillProficiency"></param>
            public void AddSkill(Skills skill, int skillProficiency)
            {
                if (Skills != null)
                {
                    Skills.Add(skill, skillProficiency);

                    return;
                }

                throw new ArgumentNullException(nameof(Skills),
                                                $"{nameof(Skills)} cannot be null when assigning a value to it.");
            }

            /// <summary>
            /// Adds an equipment/weight entry to the Dictionary that tracks equipment for this object.
            /// </summary>
            /// <param name="equipment"></param>
            /// <param name="weight"></param>
            public void AddEquipment(string equipment, int weight)
            {
                if (!string.IsNullOrEmpty(equipment) && weight > -1 && Equipment != null)
                {
                    Equipment.Add(equipment, weight);

                    return;
                }

                throw new ArgumentNullException(nameof(equipment),
                                                $"{nameof(Equipment)} cannot have an empty or null value assigned to it. Alternatively, " +
                                                $"{nameof(Equipment)} itself cannot be null when assigning a value to it.");
            }

            public void RemoveProficiency(string proficiency)
            {
                for (int i = 0; i < Proficiencies.Count; i++)
                {
                    if (Proficiencies[i].Equals(proficiency))
                    {
                        Proficiencies.RemoveAt(i);

                        return;
                    }
                }
            }

            public void RebuildProficiency(CharaStatistic statistic)
            {
                _proficiencies = statistic.Proficiencies;
            }

            public void RebuildEquipment(Dictionary<string, int> data)
            {
                _equipment = data;
            }

            public void RebuildSkills(Dictionary<Skills, int> data)
            {
                _skills = data;
            }
        }

        #endregion
    }
}
