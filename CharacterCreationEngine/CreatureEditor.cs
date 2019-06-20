using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using CharacterCreationEngine.Characteristics;

namespace CharacterCreationEngine
{
    namespace Extensions
    {
        /// <summary>
        /// Class of extension methods for setting the values of Creature-type objects.
        /// </summary>
        public static class CreatureEditor
        {
            /// <summary>
            /// Sets the Age value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Age") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="age"></param>
            public static void SetAge(this Creature creature, int age)
            {
                if (age > -1 && creature.CharacteristicDictionary.ContainsKey("Age"))
                {
                    var setAge = (CharaAge)creature.CharacteristicDictionary["Age"];

                    setAge.Age = age;
                }
            }

            /// <summary>
            /// Sets the Height value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Height") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="height"></param>
            public static void SetHeight(this Creature creature, int height)
            {
                if (height > 0 && creature.CharacteristicDictionary.ContainsKey("Height"))
                {
                    var setHeight = (CharaHeight)creature.CharacteristicDictionary["Height"];

                    setHeight.Height = height;
                }
            }

            /// <summary>
            /// Sets the Weight value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Weight") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="weight"></param>
            public static void SetWeight(this Creature creature, int weight)
            {
                if (weight > 0 && creature.CharacteristicDictionary.ContainsKey("Weight"))
                {
                    var setWeight = (CharaWeight)creature.CharacteristicDictionary["Weight"];

                    setWeight.Weight = weight;
                }
            }

            /// <summary>
            /// Sets the FirstName value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("FirstName") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="firstName"></param>
            public static void SetFirstName(this Creature creature, string firstName)
            {
                if (!string.IsNullOrEmpty(firstName) && creature.CharacteristicDictionary.ContainsKey("FirstName"))
                {
                    var setFirstName = (CharaFirstName)creature.CharacteristicDictionary["FirstName"];

                    setFirstName.FirstName = firstName;
                }
            }

            /// <summary>
            /// Sets the Surname value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Surname") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="surname"></param>
            public static void SetSurname(this Creature creature, string surname)
            {
                if (!string.IsNullOrEmpty(surname) && creature.CharacteristicDictionary.ContainsKey("Surname"))
                {
                    var setSurname = (CharaSurname)creature.CharacteristicDictionary["Surname"];

                    setSurname.Surname = surname;
                }
            }

            /// <summary>
            /// Sets the Subrace value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Subrace") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="subrace"></param>
            public static void SetSubrace(this Creature creature, string subrace)
            {
                if (!string.IsNullOrEmpty(subrace) && creature.CharacteristicDictionary.ContainsKey("Subrace"))
                {
                    var setSubrace = (CharaSubrace)creature.CharacteristicDictionary["Subrace"];

                    setSubrace.Subrace = subrace;
                }
            }

            /// <summary>
            /// Sets the Race value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Race") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="race"></param>
            public static void SetRace(this Creature creature, Race race)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Race"))
                {
                    var setRace = (CharaRace)creature.CharacteristicDictionary["Race"];

                    setRace.Race = race;
                }
            }

            /// <summary>
            /// Sets the Background value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Background") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="background"></param>
            public static void SetBackground(this Creature creature, Background background)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Background"))
                {
                    var setBackground = (CharaBackground)creature.CharacteristicDictionary["Background"];

                    setBackground.Background = background;
                }
            }

            /// <summary>
            /// Sets the RelativeSize value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("RelativeSize") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="relativeSize"></param>
            public static void SetRelativeSize(this Creature creature, RelativeSize relativeSize)
            {
                if (creature.CharacteristicDictionary.ContainsKey("RelativeSize"))
                {
                    var setRelativeSize = (CharaRelativeSize)creature.CharacteristicDictionary["RelativeSize"];

                    setRelativeSize.RelativeSize = relativeSize;
                }
            }

            /// <summary>
            /// Sets the Gender value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Gender") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="gender"></param>
            public static void SetGender(this Creature creature, Gender gender)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Gender"))
                {
                    var setGender = (CharaGender)creature.CharacteristicDictionary["Gender"];

                    setGender.Gender = gender;
                }
            }

            /// <summary>
            /// Sets the CreatureType value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("CreatureType") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="creatureType"></param>
            public static void SetCreatureType(this Creature creature, CreatureType creatureType)
            {
                if (creature.CharacteristicDictionary.ContainsKey("CreatureType"))
                {
                    var setCreatureType = (CharaCreatureType)creature.CharacteristicDictionary["CreatureType"];

                    setCreatureType.CreatureType = creatureType;
                }
            }

            /// <summary>
            /// Sets the Diet value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Diet") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="diet"></param>
            public static void SetDiet(this Creature creature, Diet diet)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Diet"))
                {
                    var setDiet = (CharaDiet)creature.CharacteristicDictionary["Diet"];

                    setDiet.Diet = diet;
                }
            }

            /// <summary>
            /// Sets the moral Alignment value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Alignment") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="alignment"></param>
            public static void SetAlignment(this Creature creature, Alignment alignment)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Alignment"))
                {
                    var setAlignment = (CharaAlignment)creature.CharacteristicDictionary["Alignment"];

                    setAlignment.Alignment = alignment;
                }
            }

            /// <summary>
            /// Sets the Tail value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Tail") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="tail"></param>
            public static void SetTail(this Creature creature, Tail tail)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Tail"))
                {
                    var setTail = (CharaTail)creature.CharacteristicDictionary["Tail"];

                    setTail.Tail = tail;
                }
            }

            /// <summary>
            /// Sets the CombatClass value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("CombatClass") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="combatClass"></param>
            public static void SetCombatClass(this Creature creature, CombatClass combatClass)
            {
                if (creature.CharacteristicDictionary.ContainsKey("CombatClass"))
                {
                    var setCombatClass = (CharaCombatClass)creature.CharacteristicDictionary["CombatClass"];

                    setCombatClass.CombatClass = combatClass;
                }
            }

            /// <summary>
            /// Sets the LifeStage value of a given Creature object, based on the average human lifespan.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target keys ("Age", "LifeStage") already exist.</para>
            /// </summary>
            /// <param name="creature"></param>
            public static void SetLifeStage(this Creature creature)
            {
                if (!creature.CharacteristicDictionary.ContainsKey("Age") ||
                    !creature.CharacteristicDictionary.ContainsKey("LifeStage"))
                {
                    return;
                }
                else
                {
                    int age = -1;
                    int.TryParse(creature.CharacteristicDictionary["Age"].ToString(), out age);

                    switch (age)
                    {
                        case int temp when (age > -1 && age < 5):
                            creature.CharacteristicDictionary["LifeStage"] = new CharaLifeStage(LifeStage.Baby);
                            return;

                        case int temp when (age > 4 && age < 9):
                            creature.CharacteristicDictionary["LifeStage"] = new CharaLifeStage(LifeStage.YoungChild);
                            return;

                        case int temp when (age > 8 && age < 13):
                            creature.CharacteristicDictionary["LifeStage"] = new CharaLifeStage(LifeStage.Child);
                            return;

                        case int temp when (age > 12 && age < 18):
                            creature.CharacteristicDictionary["LifeStage"] = new CharaLifeStage(LifeStage.YoungAdult);
                            return;

                        case int temp when (age > 17 && age < 41):
                            creature.CharacteristicDictionary["LifeStage"] = new CharaLifeStage(LifeStage.Adult);
                            return;

                        case int temp when (age > 40 && age < 55):
                            creature.CharacteristicDictionary["LifeStage"] = new CharaLifeStage(LifeStage.MiddleAged);
                            return;

                        case int temp when (age > 54 && age < 70):
                            creature.CharacteristicDictionary["LifeStage"] = new CharaLifeStage(LifeStage.Senior);
                            return;

                        case int temp when (age > 69 && age < 101):
                            creature.CharacteristicDictionary["LifeStage"] = new CharaLifeStage(LifeStage.Elder);
                            return;

                        case int temp when (age > 100):
                            creature.CharacteristicDictionary["LifeStage"] = new CharaLifeStage(LifeStage.Mythic);
                            return;

                        default:
                            creature.CharacteristicDictionary["LifeStage"] = new CharaLifeStage(LifeStage.Baby);
                            return;
                    }
                }
            }

            /// <summary>
            /// Adds a given language to a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("BaseLanguage") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="language"></param>
            public static void AddLanguage(this Creature creature, string language)
            {
                if (!string.IsNullOrEmpty(language) && creature.CharacteristicDictionary.ContainsKey("BaseLanguage"))
                {
                    var addLanguage = (CharaLanguage)creature.CharacteristicDictionary["BaseLanguage"];

                    addLanguage.AddLanguage(language);
                }
            }
            
            /// <summary>
            /// Sets the Wings value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Wings") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="wings"></param>
            public static void SetWings(this Creature creature, Wings wings)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Wings"))
                {
                    var setWings = (CharaWings)creature.CharacteristicDictionary["Wings"];

                    setWings.Wings = wings;
                }
            }
        }

        /// <summary>
        /// Class of extension methods for getting the values of Creature-type objects.
        /// </summary>
        public static class CreatureInfo
        {
            /// <summary>
            /// Gets the Age value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Age") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns an int representing the Age value.</returns>
            public static int GetAge(this Creature creature)
            {
                int temp = -1;

                if (creature.CharacteristicDictionary.ContainsKey("Age") &&
                    int.TryParse(creature.CharacteristicDictionary["Age"].ToString(), out temp))
                {
                    return temp;
                }

                return temp;
            }

            /// <summary>
            /// Gets the Height value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Height") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns an int representing the Height value.</returns>
            public static int GetHeight(this Creature creature)
            {
                int temp = -1;

                if (creature.CharacteristicDictionary.ContainsKey("Height") &&
                    int.TryParse(creature.CharacteristicDictionary["Height"].ToString(), out temp))
                {
                    return temp;
                }

                return temp;
            }

            /// <summary>
            /// Gets the Weight value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Weight") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns an int representing the Weight value.</returns>
            public static int GetWeight(this Creature creature)
            {
                int temp = -1;

                if (creature.CharacteristicDictionary.ContainsKey("Weight") &&
                    int.TryParse(creature.CharacteristicDictionary["Weight"].ToString(), out temp))
                {
                    return temp;
                }

                return temp;
            }

            /// <summary>
            /// Gets the FirstName value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("FirstName") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns a string representing the FirstName value.</returns>
            public static string GetFirstName(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("FirstName"))
                {
                    var getFirstName = (CharaFirstName)creature.CharacteristicDictionary["FirstName"];

                    return getFirstName.FirstName;
                }
                return string.Empty;
            }

            /// <summary>
            /// Gets the Surname value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Surname") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns a string representing the Surname value.</returns>
            public static string GetSurname(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Surname"))
                {
                    var getSurname = (CharaSurname)creature.CharacteristicDictionary["Surname"];

                    return getSurname.Surname;
                }
                return string.Empty;
            }

            /// <summary>
            /// Gets the Subrace value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Subrace") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns a string representing the Subrace value.</returns>
            public static string GetSubrace(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Subrace"))
                {
                    var getSubrace = (CharaSubrace)creature.CharacteristicDictionary["Subrace"];

                    return getSubrace.Subrace;
                }
                return string.Empty;
            }

            /// <summary>
            /// Gets the Description value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Description") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns a string representing the Description value.</returns>
            public static string GetDescription(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Description"))
                {
                    var getDescription = (CharaDescription)creature.CharacteristicDictionary["Description"];

                    return getDescription.Description;
                }
                return string.Empty;
            }

            /// <summary>
            /// Gets the BaseLanguage value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("BaseLanguage") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns a string representing the BaseLanguage value.</returns>
            public static string GetBaseLanguage(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("BaseLanguage"))
                {
                    var getBaseLanguage = (CharaLanguage)creature.CharacteristicDictionary["BaseLanguage"];

                    return getBaseLanguage.BaseLanguage;
                }
                return string.Empty;
            }

            /// <summary>
            /// Gets a list of Languages known by this Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("BaseLanguage") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns a list of strings that represent all languages "known" by the target Creature.</returns>
            public static List<string> GetLanguageList(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("BaseLanguage"))
                {
                    var getLanguageList = (CharaLanguage)creature.CharacteristicDictionary["BaseLanguage"];

                    return getLanguageList.Languages;
                }
                return null;
            }

            /// <summary>
            /// Gets the Race value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Race") already exist.</para>
            /// </summary>
            /// <para name="creature"></para>
            /// <returns>Returns an Enum value representing the Race value.</returns>
            public static Enum GetRace(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Race"))
                {
                    var getRace = (CharaRace)creature.CharacteristicDictionary["Race"];

                    return getRace.Race;
                }
                return null;
            }

            /// <summary>
            /// Gets the Background value of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Background") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns an Enum value representing the Background value.</returns>
            public static Enum GetBackground(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Background"))
                {
                    var getBackground = (CharaBackground)creature.CharacteristicDictionary["Background"];

                    return getBackground.Background;
                }
                return null;
            }

            /// <summary>
            /// Gets the RelativeSize value of a given Creature object, ignoring any custom Enum descriptions.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("RelativeSize") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns an Enum value representing the RelativeSize value.</returns>
            public static Enum GetRelativeSize(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("RelativeSize"))
                {
                    var getRelativeSize = (CharaRelativeSize)creature.CharacteristicDictionary["RelativeSize"];

                    return getRelativeSize.RelativeSize;
                }
                return null;
            }

            /// <summary>
            /// Gets the Gender value of a given Creature object, ignoring any custom Enum descriptions.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Gender") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns an Enum value representing the Gender value.</returns>
            public static Enum GetGender(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Gender"))
                {
                    var getGender = (CharaGender)creature.CharacteristicDictionary["Gender"];

                    return getGender.Gender;
                }
                return null;
            }

            /// <summary>
            /// Gets the CreatureType value of a given Creature object, ignoring any custom Enum descriptions.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("CreatureType") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns an Enum value representing the CreatureType value.</returns>
            public static Enum GetCreatureType(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("CreatureType"))
                {
                    var getCreatureType = (CharaCreatureType)creature.CharacteristicDictionary["CreatureType"];

                    return getCreatureType.CreatureType;
                }
                return null;
            }

            /// <summary>
            /// Gets the Diet value of a given Creature object, ignoring any custom Enum descriptions.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Diet") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns an Enum value representing the Diet value.</returns>
            public static Enum GetDiet(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Diet"))
                {
                    var getDiet = (CharaDiet)creature.CharacteristicDictionary["Diet"];

                    return getDiet.Diet;
                }
                return null;
            }

            /// <summary>
            /// Gets the moral Alignment value of a given Creature object, ignoring any custom Enum descriptions.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Alignment") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns an Enum value representing the Alignment value.</returns>
            public static Enum GetAlignment(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Alignment"))
                {
                    var getAlignment = (CharaAlignment)creature.CharacteristicDictionary["Alignment"];

                    return getAlignment.Alignment;
                }
                return null;
            }

            /// <summary>
            /// Gets the Tail value of a given Creature object, ignoring any custom Enum descriptions.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Tail") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns an Enum value representing the Tail value.</returns>
            public static Enum GetTail(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Tail"))
                {
                    var getTail = (CharaTail)creature.CharacteristicDictionary["Tail"];

                    return getTail.Tail;
                }
                return null;
            }

            /// <summary>
            /// Gets the CombatClass value of a given Creature object, ignoring any custom Enum descriptions.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("CombatClass") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns an Enum value representing the CombatClass value.</returns>
            public static Enum GetCombatClass(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("CombatClass"))
                {
                    var getCombatClass = (CharaCombatClass)creature.CharacteristicDictionary["CombatClass"];

                    return getCombatClass.CombatClass;
                }
                return null;
            }

            /// <summary>
            /// Gets the LifeStage value of a given Creature object, ignoring any custom Enum descriptions.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("LifeStage") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns an Enum value representing the LifeStage value.</returns>
            public static Enum GetLifeStage(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("LifeStage"))
                {
                    var getLifeStage = (CharaLifeStage)creature.CharacteristicDictionary["LifeStage"];

                    return getLifeStage.LifeStage;
                }
                return null;
            }

            /// <summary>
            /// Gets the Wings value of a given Creature object, ignoring any custom Enum descriptions.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Wings") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns an Enum value representing the LifeStage value.</returns>
            public static Enum GetWings(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Wings"))
                {
                    var getWings = (CharaWings)creature.CharacteristicDictionary["Wings"];

                    return getWings.Wings;
                }
                return null;
            }

            /// <summary>
            /// Gets the CharaStatistic object of a given Creature object.
            /// <para>Will operate on the Creature object's CharacteristicDictionary only if the target key ("Statistics") already exists.</para>
            /// </summary>
            /// <param name="creature"></param>
            /// <returns>Returns the CharaStatistic object of a given Creature object.</returns>
            public static CharaStatistic GetCharaStatistic(this Creature creature)
            {
                if (creature.CharacteristicDictionary.ContainsKey("Statistics"))
                {
                    return (CharaStatistic)creature.CharacteristicDictionary["Statistics"];
                }
                return null;
            }

            /// <summary>
            /// Determines whether the value at the given string key is an Enum value, then attempts to get a custom description from it.
            /// </summary>
            /// <param name="creature"></param>
            /// <param name="key"></param>
            /// <returns>Returns an Enum's custom description, if found. Returns the field itself otherwise. Returns null upon error.</returns>
            public static string GetEnumDescription(this Creature creature, string key)
            {
                //if the given key isn't empty/null AND if the CharacteristicDictionary of the given Creature object actually has the specified key...
                if (!string.IsNullOrEmpty(key) && creature.CharacteristicDictionary.ContainsKey(key))
                {
                    //try to retrieve an Enum type from the CharacteristicDictionary of the supplied creature object, at the position specified by the key
                    //var is used here because a null value can possibly be returned
                    var retrievedEnum = GetCharacteristicEnumType(creature.CharacteristicDictionary[key]);

                    //if the retrieved type is an Enum type AND isn't null, 
                    //try to get a custom attribute from its currently set field
                    //return the description
                    if (retrievedEnum.GetType().IsEnum && retrievedEnum != null)
                    {
                        Type enumType = retrievedEnum.GetType();
                        string name = Enum.GetName(enumType, retrievedEnum);

                        if (!string.IsNullOrEmpty(name))
                        {
                            FieldInfo field = enumType.GetField(name);

                            if (field != null)
                            {
                                //returns the custom description of the retrieved enum's set field if there is one
                                if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attr)
                                {
                                    return attr.Description;
                                }

                                //if there is no custom description, this returns the field of the enum instead
                                return retrievedEnum.ToString();
                            }
                            return "<!> the field of the Enum that was pointed to is not set OR null <!>";
                        }
                        return "<!> the name of the Enum that was pointed to is null <!>";
                    }
                    return "<!> the specified key does not point to an Enum value OR the Enum value is null <!>";
                }
                return "<!> the supplied key is empty/null OR it doesn't exist in the CharacteristicDictionary <!>";
            }

            /// <summary>
            /// Private helper method for the GetEnumDescription method.
            /// </summary>
            /// <param name="charaObject"></param>
            /// <returns>Returns the Enum type of a given Characteristic object if it is an Enum type.</returns>
            private static Enum GetCharacteristicEnumType(Characteristic charaObject)
            {
                if (charaObject != null)
                {
                    switch (charaObject.GetType().Name)
                    {
                        case "CharaRelativeSize":
                            var charaRelativeSize = (CharaRelativeSize)charaObject;
                            return charaRelativeSize.RelativeSize;
                        case "CharaGender":
                            var charaGender = (CharaGender)charaObject;
                            return charaGender.Gender;
                        case "CharaCreatureType":
                            var charaCreatureType = (CharaCreatureType)charaObject;
                            return charaCreatureType.CreatureType;
                        case "CharaDiet":
                            var charaDiet = (CharaDiet)charaObject;
                            return charaDiet.Diet;
                        case "CharaAlignment":
                            var charaAlignment = (CharaAlignment)charaObject;
                            return charaAlignment.Alignment;
                        case "CharaTail":
                            var charaTail = (CharaTail)charaObject;
                            return charaTail.Tail;
                        case "CharaCombatClass":
                            var charaCombatClass = (CharaCombatClass)charaObject;
                            return charaCombatClass.CombatClass;
                        case "CharaLifeStage":
                            var charaLifeStage = (CharaLifeStage)charaObject;
                            return charaLifeStage.LifeStage;
                        case "CharaBackground":
                            var charaBackground = (CharaBackground)charaObject;
                            return charaBackground.Background;
                        case "CharaRace":
                            var charaRace = (CharaRace)charaObject;
                            return charaRace.Race;
                        case "CharaWings":
                            var charaWings = (CharaWings)charaObject;
                            return charaWings.Wings;
                        default:
                            return null;
                    }
                }
                return null;
            }
        }
    }
}
