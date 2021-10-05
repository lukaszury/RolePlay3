using System;

namespace RoleplayGame
{
    public abstract class Enemy : Character
    {
        protected Enemy(string name) : base(name)
        {
            this.Name = name;
        }
        
    }
}