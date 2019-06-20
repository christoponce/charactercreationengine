using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using CharacterCreationEngine.Characteristics;

namespace CharacterCreationEngine
{
    public class CreatureXML
    {
        //contains all types in the "CharacterCreationEngine.Characteristics" namespace within the currently-executing assembly
        private static readonly List<Type> knownTypes = GetNamespaceTypes(Assembly.GetExecutingAssembly(), "CharacterCreationEngine.Characteristics").ToList();

        public void WriteStatsToXML(string path, CharaStatistic stats)
        {
            if (!string.IsNullOrEmpty(path) && stats != null)
            {
                var serializer = new DataContractSerializer(typeof(CharaStatistic));

                using (var sw = new StreamWriter(path))
                {
                    using (var writer = new XmlTextWriter(sw))
                    {
                        writer.Formatting = Formatting.Indented;
                        serializer.WriteObject(writer, stats);
                        writer.Flush();
                    }
                }
            }
        }

        /// <summary>
        /// Writes a List of Creature objects to an *.xml file. Will overwrite an existing *.xml file if it has the same name.
        /// </summary>
        /// <param name="path"></param>
        public void WriteToXML(string path, Creature data)
        {
            if (!string.IsNullOrEmpty(path) && data != null)
            {
                //create DataContractSerializer of type List<Creature>
                //give list of all known types associated with Creature objects
                var serializer = new DataContractSerializer(typeof(Creature), knownTypes);

                using (var sw = new StreamWriter(path))
                {
                    using (var writer = new XmlTextWriter(sw))
                    {
                        writer.Formatting = Formatting.Indented;
                        serializer.WriteObject(writer, data);
                        writer.Flush();
                    }
                }
            }
        }

        /// <summary>
        /// Deserializes an XML file via DataContractSerializer.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Returns a Dictionary containing all Creature objects deserialized from the target XML file.</returns>
        public Creature ReadFromXML(string path)
        {
            //path cannot be empty and the target XML file must already exist, otherwise returns null
            if (!string.IsNullOrEmpty(path) &&
                File.Exists(path))
            {
                Creature loadedData;
                var xs = new DataContractSerializer(typeof(Creature), knownTypes);

                using (var sr = new StreamReader(path))
                {
                    using (var reader = new XmlTextReader(sr))
                    {
                        loadedData = (Creature)xs.ReadObject(reader);
                    }
                }

                return loadedData;
            }
            return null;
        }
        
        /// <summary>
        /// Gets an array of all types within a given namespace and assembly.
        /// </summary>
        /// <param name="assembly"></param>
        /// <param name="nameSpace"></param>
        /// <returns>Returns a Type[] containing all types within a given namespace and assembly.</returns>
        private static Type[] GetNamespaceTypes(Assembly assembly, string nameSpace)
        {
            return assembly.GetTypes()
                           .Where(type => string.Equals(type.Namespace, nameSpace, StringComparison.Ordinal))
                           .ToArray();
        }
    }
}
