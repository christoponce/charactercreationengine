namespace CharacterCreationEngine
{
    public class CreatureBuilder
    {
        public CreatureBuilder(Race race)
        {
            NewCreature = GetCreature(race);
        }

        public Creature NewCreature { get; set; }

        /// <summary>
        /// Takes a Race enum value and returns a new instance of the equivalent enum value.
        /// <para>Example: Race.Human with return "new Human();"</para>
        /// </summary>
        /// <param name="race"></param>
        /// <returns>Returns a new instance of the determined race's class.</returns>
        public Creature GetCreature(Race race)
        {
            switch (race)
            {
                case Race.Human:
                    return new Human();
                case Race.Dwarf:
                    return new Dwarf();
                case Race.Elf:
                    return new Elf();
                case Race.Halfling:
                    return new Halfling();
                case Race.Gnome:
                    return new Gnome();
                default:
                    return null;
            }
        }
    }
}
