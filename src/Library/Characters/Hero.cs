namespace RoleplayGame
{
    public abstract class Hero : Character
    {
        protected Hero(string name) : base(name)
        {
            this.Name = name;
        }

    }
}