using System.Runtime.Serialization;
using CharacterCreationEngine.Characteristics;

namespace CharacterCreationEngine
{
    /// <summary>
    /// Concrete creator class for Human-type objects.
    /// </summary>
    [DataContract]
    public class Human : Creature
    {
        //empty constructor; calls the Factory method
        public Human() { }

        //this method is called by the constructor as soon as a new instance of this class is created
        public override void BuildCharacteristics()
        {
            //adds Human-specific characteristics to the dictionary for this instance
            CharacteristicDictionary.Add("Race", new CharaRace(Race.Human));
            CharacteristicDictionary.Add("Subrace", new CharaSubrace(string.Empty));
            CharacteristicDictionary.Add("FirstName", new CharaFirstName("John"));
            CharacteristicDictionary.Add("Surname", new CharaSurname("Doe"));
            CharacteristicDictionary.Add("BaseLanguage", new CharaLanguage());
            CharacteristicDictionary.Add("Background", new CharaBackground(Background.Soldier));
            CharacteristicDictionary.Add("Age", new CharaAge(18));

            //defaults based on the world-wide average height and weight for Humans as a whole
            //Height is in inches
            //Weight is in pounds
            CharacteristicDictionary.Add("Height", new CharaHeight(66));
            CharacteristicDictionary.Add("Weight", new CharaWeight(155));

            //default enum characteristics to avoid accessing a null field
            CharacteristicDictionary.Add("RelativeSize", new CharaRelativeSize(RelativeSize.Average));
            CharacteristicDictionary.Add("Gender", new CharaGender(Gender.Male));
            CharacteristicDictionary.Add("CreatureType", new CharaCreatureType(CreatureType.Mammal));
            CharacteristicDictionary.Add("Diet", new CharaDiet(Diet.Omnivore));
            CharacteristicDictionary.Add("Alignment", new CharaAlignment(Alignment.TrueNeutral));
            CharacteristicDictionary.Add("Tail", new CharaTail(Tail.None));
            CharacteristicDictionary.Add("Wings", new CharaWings(Wings.None));
            CharacteristicDictionary.Add("CombatClass", new CharaCombatClass(CombatClass.Warrior));
            CharacteristicDictionary.Add("LifeStage", new CharaLifeStage(LifeStage.Adult));

            //Statistic object
            CharacteristicDictionary.Add("Statistics", new CharaStatistic());

            //Human race description
            CharacteristicDictionary.Add("Description", new CharaDescription(
                "Humans are among the most adaptable and ambitious of all races. " +
                "Because of their shorter lives (in comaprison to other races), " +
                "they strive to achieve as much as they can with what little time they have. " +
                "Whatever the core reason, they are the innovators, achievers, and pioneers of the world."));
        }
    }

    /// <summary>
    /// Concrete creator class for Elf-type objects.
    /// </summary>
    [DataContract]
    public class Elf : Creature
    {
        //empty constructor; calls the Factory method
        public Elf() { }

        //this method is called by the constructor as soon as a new instance of this class is created
        public override void BuildCharacteristics()
        {
            //adds Elf-specific characteristics to the dictionary for this instance
            CharacteristicDictionary.Add("Race", new CharaRace(Race.Elf));
            CharacteristicDictionary.Add("Subrace", new CharaSubrace(string.Empty));
            CharacteristicDictionary.Add("FirstName", new CharaFirstName("Adran"));
            CharacteristicDictionary.Add("Surname", new CharaSurname("Amakiir"));
            CharacteristicDictionary.Add("BaseLanguage", new CharaLanguage());
            CharacteristicDictionary.Add("Background", new CharaBackground(Background.Courtier));
            CharacteristicDictionary.Add("Age", new CharaAge(18));

            //defaults based on the world-wide average height and weight for Elves as a whole
            //Height is in inches
            //Weight is in pounds
            CharacteristicDictionary.Add("Height", new CharaHeight(66));
            CharacteristicDictionary.Add("Weight", new CharaWeight(120));

            //default enum characteristics to avoid accessing a null field
            CharacteristicDictionary.Add("RelativeSize", new CharaRelativeSize(RelativeSize.Average));
            CharacteristicDictionary.Add("Gender", new CharaGender(Gender.Male));
            CharacteristicDictionary.Add("CreatureType", new CharaCreatureType(CreatureType.Mammal));
            CharacteristicDictionary.Add("Diet", new CharaDiet(Diet.Omnivore));
            CharacteristicDictionary.Add("Alignment", new CharaAlignment(Alignment.TrueNeutral));
            CharacteristicDictionary.Add("Tail", new CharaTail(Tail.None));
            CharacteristicDictionary.Add("Wings", new CharaWings(Wings.None));
            CharacteristicDictionary.Add("CombatClass", new CharaCombatClass(CombatClass.Ranger));
            CharacteristicDictionary.Add("LifeStage", new CharaLifeStage(LifeStage.Adult));

            //Statistic object
            CharacteristicDictionary.Add("Statistics", new CharaStatistic());

            //Elf race description
            CharacteristicDictionary.Add("Description", new CharaDescription(
                "Elves are a magical people that radiate grace in excess. " +
                "They tend to live in regions of great natural beauty, such as " +
                "deep ancient forests set alight by ethereal faerie glows where " +
                "gentle music drifts through the lukewarm air. Elves live a much longer " +
                "life than many, giving them a unique perspective of the world and those " +
                "within it. This causes them to be more amused and curious than excited and greedy."));
        }
    }

    /// <summary>
    /// Concrete creator class for Dwarf-type objects.
    /// </summary>
    [DataContract]
    public class Dwarf : Creature
    {
        //empty constructor; calls the Factory method
        public Dwarf() { }

        //this method is called by the constructor as soon as a new instance of this class is created
        public override void BuildCharacteristics()
        {
            //adds Dwarf-specific characteristics to the dictionary for this instance
            CharacteristicDictionary.Add("Race", new CharaRace(Race.Dwarf));
            CharacteristicDictionary.Add("Subrace", new CharaSubrace(string.Empty));
            CharacteristicDictionary.Add("FirstName", new CharaFirstName("Darrak"));
            CharacteristicDictionary.Add("Surname", new CharaSurname("Rumnaheim"));
            CharacteristicDictionary.Add("BaseLanguage", new CharaLanguage());
            CharacteristicDictionary.Add("Background", new CharaBackground(Background.ClanCrafter));
            CharacteristicDictionary.Add("Age", new CharaAge(18));

            //defaults based on the world-wide average height and weight for Dwarves as a whole
            //Height is in inches
            //Weight is in pounds
            CharacteristicDictionary.Add("Height", new CharaHeight(45));
            CharacteristicDictionary.Add("Weight", new CharaWeight(155));

            //default enum characteristics to avoid accessing a null field
            CharacteristicDictionary.Add("RelativeSize", new CharaRelativeSize(RelativeSize.Average));
            CharacteristicDictionary.Add("Gender", new CharaGender(Gender.Male));
            CharacteristicDictionary.Add("CreatureType", new CharaCreatureType(CreatureType.Mammal));
            CharacteristicDictionary.Add("Diet", new CharaDiet(Diet.Omnivore));
            CharacteristicDictionary.Add("Alignment", new CharaAlignment(Alignment.TrueNeutral));
            CharacteristicDictionary.Add("Tail", new CharaTail(Tail.None));
            CharacteristicDictionary.Add("Wings", new CharaWings(Wings.None));
            CharacteristicDictionary.Add("CombatClass", new CharaCombatClass(CombatClass.Fighter));
            CharacteristicDictionary.Add("LifeStage", new CharaLifeStage(LifeStage.Adult));

            //Statistic object
            CharacteristicDictionary.Add("Statistics", new CharaStatistic());

            //Dwarf race description
            CharacteristicDictionary.Add("Description", new CharaDescription(
                "Dwarves are a people that live beneath great mountains in stone halls " +
                "carved out by many generations of hardy blacksmiths and miners." +
                "Though they usually stand at heights much shorter than other races, " +
                "Dwarves are a strong and heavy folk that make good use of their lower center of gravity. " +
                "All Dwarves maintain a strong sense of clan and tradition - if you wrong one Dwarf, " +
                "you've wronged their entire clan."));
        }
    }

    /// <summary>
    /// Concrete creator class for Halfling-type objects.
    /// </summary>
    [DataContract]
    public class Halfling : Creature
    {
        //empty constructor; calls the Factory method
        public Halfling() { }

        //this method is called by the constructor as soon as a new instance of this class is created
        public override void BuildCharacteristics()
        {
            //adds Halfling-specific characteristics to the dictionary for this instance
            CharacteristicDictionary.Add("Race", new CharaRace(Race.Halfling));
            CharacteristicDictionary.Add("Subrace", new CharaSubrace(string.Empty));
            CharacteristicDictionary.Add("FirstName", new CharaFirstName("Corrin"));
            CharacteristicDictionary.Add("Surname", new CharaSurname("Tealeaf"));
            CharacteristicDictionary.Add("BaseLanguage", new CharaLanguage());
            CharacteristicDictionary.Add("Background", new CharaBackground(Background.Entertainer));
            CharacteristicDictionary.Add("Age", new CharaAge(18));

            //defaults based on the world-wide average height and weight for Halflings as a whole
            //Height is in inches
            //Weight is in pounds
            CharacteristicDictionary.Add("Height", new CharaHeight(36));
            CharacteristicDictionary.Add("Weight", new CharaWeight(45));

            //default enum characteristics to avoid accessing a null field
            CharacteristicDictionary.Add("RelativeSize", new CharaRelativeSize(RelativeSize.Average));
            CharacteristicDictionary.Add("Gender", new CharaGender(Gender.Male));
            CharacteristicDictionary.Add("CreatureType", new CharaCreatureType(CreatureType.Mammal));
            CharacteristicDictionary.Add("Diet", new CharaDiet(Diet.Omnivore));
            CharacteristicDictionary.Add("Alignment", new CharaAlignment(Alignment.TrueNeutral));
            CharacteristicDictionary.Add("Tail", new CharaTail(Tail.None));
            CharacteristicDictionary.Add("Wings", new CharaWings(Wings.None));
            CharacteristicDictionary.Add("CombatClass", new CharaCombatClass(CombatClass.Bard));
            CharacteristicDictionary.Add("LifeStage", new CharaLifeStage(LifeStage.Adult));

            //Statistic object
            CharacteristicDictionary.Add("Statistics", new CharaStatistic());

            //Halfling race description
            CharacteristicDictionary.Add("Description", new CharaDescription(
                "Halflings are a smaller people who dream of settling down in a quiet place, " +
                "as far away from danger and strife as possible. Generally standing only about a meter tall, " +
                "Halflings try to avoid an early grave by way of avoiding detection and contention whenever they can. " +
                "Halflings are a very cheerful and welcoming people, cherishing family and friends over " +
                "gold or glory. Their biggest personal concerns don't extend much further than their own basic needs or " +
                "the more simpler things in life. They hate to see suffering and are quick to pity, but are very loyal and modest."));
        }
    }

    /// <summary>
    /// Concrete creator class for Gnome-type objects.
    /// </summary>
    [DataContract]
    public class Gnome : Creature
    {
        //empty constructor; calls the Factory method
        public Gnome() { }

        //this method is called by the constructor as soon as a new instance of this class is created
        public override void BuildCharacteristics()
        {
            //adds Gnome-specific characteristics to the dictionary for this instance
            CharacteristicDictionary.Add("Race", new CharaRace(Race.Gnome));
            CharacteristicDictionary.Add("Subrace", new CharaSubrace(string.Empty));
            CharacteristicDictionary.Add("FirstName", new CharaFirstName("Wrenn"));
            CharacteristicDictionary.Add("Surname", new CharaSurname("Nackle"));
            CharacteristicDictionary.Add("BaseLanguage", new CharaLanguage());
            CharacteristicDictionary.Add("Background", new CharaBackground(Background.Outlander));
            CharacteristicDictionary.Add("Age", new CharaAge(18));

            //defaults based on the world-wide average height and weight for Gnomes as a whole
            //Height is in inches
            //Weight is in pounds
            CharacteristicDictionary.Add("Height", new CharaHeight(40));
            CharacteristicDictionary.Add("Weight", new CharaWeight(40));

            //default enum characteristics to avoid accessing a null field
            CharacteristicDictionary.Add("RelativeSize", new CharaRelativeSize(RelativeSize.Average));
            CharacteristicDictionary.Add("Gender", new CharaGender(Gender.Male));
            CharacteristicDictionary.Add("CreatureType", new CharaCreatureType(CreatureType.Mammal));
            CharacteristicDictionary.Add("Diet", new CharaDiet(Diet.Omnivore));
            CharacteristicDictionary.Add("Alignment", new CharaAlignment(Alignment.TrueNeutral));
            CharacteristicDictionary.Add("Tail", new CharaTail(Tail.None));
            CharacteristicDictionary.Add("Wings", new CharaWings(Wings.None));
            CharacteristicDictionary.Add("CombatClass", new CharaCombatClass(CombatClass.Rogue));
            CharacteristicDictionary.Add("LifeStage", new CharaLifeStage(LifeStage.Adult));

            //Statistic object
            CharacteristicDictionary.Add("Statistics", new CharaStatistic());

            //Gnome race description
            CharacteristicDictionary.Add("Description", new CharaDescription(
                "Gnomes are close-knit people that form small warrens of constant activity wherever they may collect." +
                "With sudden bouts of laughter, cheering, and yelps of surprise echoing through their ranks, it is clear " +
                "that Gnomes try enjoy their lives to the fullest. They are a highly inventive, curious, imaginative, and playful " +
                "people that are bent on squeezing every ounce of enjoyment out of their very long lives. Though their joy for living " +
                "usually comes across as delightful, many have a tendency to be pranksters, jokesters, or even rather mischievous."));
        }
    }
    
}