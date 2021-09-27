namespace RoleplayGame
{
    public class Wizard
    {
        private int health = 100;

        public Wizard(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public SpellsBook SpellsBook { get; set; }

        public Staff Staff { get; set; }

        public int AttackValue
        {
            get
            {
                if (Staff != null && SpellsBook != null)
                {
                    return SpellsBook.AttackValue + Staff.AttackValue;
                }
                if (Staff != null)
                {
                    return Staff.AttackValue;
                }
                if (SpellsBook != null)
                {
                    return SpellsBook.AttackValue;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int DefenseValue
        {
            get
            {
                if (Staff != null && SpellsBook != null)
                {
                    return SpellsBook.DefenseValue + Staff.DefenseValue;
                }
                if (Staff != null)
                {
                    return Staff.DefenseValue;
                }
                if (SpellsBook != null)
                {
                    return SpellsBook.DefenseValue;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}