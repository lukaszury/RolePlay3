namespace RoleplayGame
{
    public class Knight : ICharacter
    {
        private int health = 100;

        public Knight(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public IAttackValue Sword { get; set; }

        public IDefenseValue Shield { get; set; }

        public IDefenseValue Armor { get; set; }

        public int AttackValue
        {
            get
            {
                if (Sword != null)
                {
                    return Sword.AttackValue;
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
                if (Armor != null && Shield != null)
                {
                    return Shield.DefenseValue + Armor.DefenseValue;
                }
                if (Armor != null)
                {
                    return Armor.DefenseValue;
                }
                if (Shield != null)
                {
                    return Shield.DefenseValue;
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