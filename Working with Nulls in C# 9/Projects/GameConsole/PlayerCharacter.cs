namespace GameConsole
{
    class PlayerCharacter
    {

        //public string Name { get; set; }
        //public int? DaysSinceLastLogin { get; set; }
        //public DateTime? DateOfBirth { get; set; }
        //public bool? IsNew { get; set; }

        private readonly ISpecialDefense _specialDefence;
        public string Name { get; set; }
        public int Health { get; private set; } = 100;

        public PlayerCharacter( ISpecialDefense specialDefense)
        {
            _specialDefence = specialDefense;
        }

        public void Hit (int damage)
        {
            int damageReduction = 0;

            if (_specialDefence != null)
            {
                damageReduction = _specialDefence.CalculateDamageReduction();
            }

            int totalDamageTaken = Math.Abs(damage - damageReduction);

            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");
        }

    }
}
