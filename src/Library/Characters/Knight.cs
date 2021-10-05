namespace RoleplayGame
{
    public class Knight : Character
    {
        private int health = 100;

        public Knight(string name) : base(name)
        {
            Sword = new Sword();
        }


        public IAttackValue Sword { get; set; }

        public IDefenseValue Shield { get; set; }

        public IDefenseValue Armor { get; set; }

        public override int AttackValue
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

        public override int DefenseValue
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