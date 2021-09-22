namespace RoleplayGame
{
    public class Bow : IAttackValue,IDefenseValue
    {
        public int AttackValue 
        {
            get
            {
                return 15;
            } 
        }
    }
}