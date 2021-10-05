using System;

namespace RoleplayGame
{
    public abstract class Character
    {
        protected Character(string name)
        {
            this.Name = name;
            this.VictoryPoints = 100;
        }

        public string Name{get; protected set;}

        public int VictoryPoints{get;set;}

        public abstract int Health {get; set;}

        public abstract int AttackValue {get;}

        public abstract int DefenseValue {get;}

        public abstract void ReceiveAttack(int power);

        public virtual void ReceiveVictoryPointsFromEnemy(int points)
        {
            this.VictoryPoints += points;
        }

        public abstract void Cure();
    }
}