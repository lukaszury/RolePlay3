namespace RoleplayGame
{
    public class Sword : IAttackValue,IDefenseValue
    {
        public int AttackValue 
        {
            get
            {
                return 20;
            } 
        }
    }
}