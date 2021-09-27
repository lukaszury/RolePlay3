namespace RoleplayGame
{
    public class Archer
    {
        private int health = 100;

        public Archer(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        
        public Bow Bow { get; set; }

        public Helmet Helmet { get; set; }

        public int AttackValue
        {
            get
            {
                if (Bow != null)
                {
                    return Bow.AttackValue;
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
                if (Helmet != null)
                {
                    return Helmet.DefenseValue;
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