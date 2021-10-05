using System;

namespace RoleplayGame
{
    public abstract class Character
    {
        protected Character(string name)
        {
            this.Name = name;
        }

        public string Name{get; protected set;}

        public abstract int Health {get; set;}

        public abstract int AttackValue {get;}

        public abstract int DefenseValue {get;}

        public abstract void ReceiveAttack(int power);

        public abstract void Cure();
    }
}