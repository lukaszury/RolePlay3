namespace RoleplayGame
{
    public class Dwarf : Character
    {
        private int health = 100;
        

        public Dwarf(string name) : base(name)
        {
            this.Axe = new Axe();
        }

        public IAttackValue Axe { get; set; }

        public IDefenseValue Shield { get; set; }

        public IDefenseValue Helmet { get; set; }

        public override int AttackValue
        {
            get
            {
                if (Axe != null)
                {
                    return Axe.AttackValue;
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
                if (Helmet != null && Shield != null)
                {
                    return Shield.DefenseValue + Helmet.DefenseValue;
                }
                if (Helmet != null)
                {
                    return Helmet.DefenseValue;
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