namespace RoleplayGame
{
    public class Empty : IDefenseValue,IAttackValue
    {
        public int DefenseValue
        {
            get
            {
                return 0;
            }
        }
        public int AttackValue
        {
            get
            {
                return 0;
            }
        }
    }
}