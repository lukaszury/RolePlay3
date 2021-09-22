namespace RoleplayGame
{
    public interface ICharacter
    {
        int helath
        string name
        int AttackValue();
        int DefenseValue();
        int Health();
        void ReceiveAttack();
        void Cure();
    }
}
