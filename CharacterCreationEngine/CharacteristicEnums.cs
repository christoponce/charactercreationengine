using System.ComponentModel;

namespace CharacterCreationEngine
{
    //creature body size descriptor
    public enum RelativeSize
    {
        Tiny,
        Small,
        Average,
        Large,
        Huge,
        Colossal
    }

    //creature gender
    public enum Gender
    {
        Male,
        Female,
        None,
        Other
    }

    //descriptor for what group the creature belongs to
    public enum CreatureType
    {
        Invertebrate,
        Fish,
        Amphibian,
        Reptile,
        Bird,
        Mammal,
        Other
    }

    //descriptor for a creature's diet
    public enum Diet
    {
        Herbivore,
        Carnivore,
        Omnivore
    }

    //moral alignment descriptor
    //creatures with no morality / not sapient enough to make decisions based on alignment shall use the "Unaligned" option only
    public enum Alignment
    {
        [Description("Lawful Good")]
        LawfulGood,
        [Description("Neutral Good")]
        NeutralGood,
        [Description("Chaotic Good")]
        ChaoticGood,
        [Description("Lawful Neutral")]
        LawfulNeutral,
        [Description("True Neutral")]
        TrueNeutral,
        [Description("Chaotic Neutral")]
        ChaoticNeutral,
        [Description("Lawful Evil")]
        LawfulEvil,
        [Description("Neutral Evil")]
        NeutralEvil,
        [Description("Chaotic Evil")]
        ChaoticEvil,
        [Description("Unaligned")]
        Unaligned
    }

    //tail descriptor
    public enum Tail
    {
        None,
        Short,
        Medium,
        Long
    }

    //descriptor for character classes
    public enum CombatClass
    {
        Barbarian,
        Bard,
        Cleric,
        Druid,
        Fighter,
        Monk,
        Paladin,
        Ranger,
        Rogue,
        Sorcerer,
        Warlock,
        Warrior,
        Wizard,
        None
    }

    //descriptor for lifestages
    public enum LifeStage
    {
        Baby,
        [Description("Young Child")]
        YoungChild,
        Child,
        [Description("Young Adult")]
        YoungAdult,
        Adult,
        [Description("Middle-aged")]
        MiddleAged,
        Senior,
        Elder,
        Mythic
    }

    //descriptor for character backgrounds
    public enum Background
    {
        Acolyte,
        Anthropologist,
        Archaeologist,
        Charlatan,
        [Description("City Watch")]
        CityWatch,
        [Description("Clan Crafter")]
        ClanCrafter,
        [Description("Cloistered Scholar")]
        CloisteredScholar,
        Courtier,
        Criminal,
        Entertainer,
        [Description("Faction Agent")]
        FactionAgent,
        [Description("Far Traveler")]
        FarTraveler,
        [Description("Folk Hero")]
        FolkHero,
        [Description("Guild Artisan")]
        GuildArtisan,
        [Description("Haunted One")]
        HauntedOne,
        Hermit,
        [Description("House Agent")]
        HouseAgent,
        Inheritor,
        Initiate,
        Inquisitor,
        [Description("Knight of the Order")]
        KnightOfTheOrder,
        [Description("Mercenary Veteran")]
        MercenaryVeteran,
        Noble,
        Outlander,
        Sage,
        Sailor,
        Soldier,
        [Description("Urban Bounty Hunter")]
        UrbanBountyHunter,
        Urchin,
        Villager,
        Unknown
    }

    //descriptor for Race
    public enum Race
    {
        Human,
        Elf,
        Dwarf,
        Halfling,
        Gnome
    }

    //descriptor for Wings
    public enum Wings
    {
        None,
        Two,
        Four,
        Six
    }

    //descriptor for skills
    public enum Skills
    {
        Acrobatics,
        [Description("Animal Handling")]
        AnimalHandling,
        Arcana,
        Athletics,
        Deception,
        History,
        Insight,
        Intimidation,
        Investigation,
        Medicine,
        Nature,
        Perception,
        Performance,
        Persuasion,
        Religion,
        [Description("Sleight of Hand")]
        SleightOfHand,
        Stealth,
        Survival
    }
}
