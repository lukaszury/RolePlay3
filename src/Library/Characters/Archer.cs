namespace RoleplayGame
{
    public class Archer : Character
    {
        private int health = 100;

        public Archer(string name) : base(name)
        {
            this.Name = name;
            this.Helmet = new Helmet();
        }

        public IAttackValue Bow { get; set; }

        public IDefenseValue Helmet { get; set; }

        public override int AttackValue
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

        public override int DefenseValue
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

        public override int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public override void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public override void Cure()
        {
            this.Health = 100;
        }
    }
}