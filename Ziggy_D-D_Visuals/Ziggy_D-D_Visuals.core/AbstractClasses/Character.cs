namespace Ziggy_D_D_Visuals.core.AbstractClasses
{
    public abstract class Character: BaseEntity
    {
        public string NameCharacter  { get; private set; }       
        public int BaseArmor { get; private set; }
        public int BaseAttack { get; private set;}
        public int BaseHealth { get; private set; }

        public Character(string nameCharacter, int baseArmor, int baseAttack, int baseHealth)
        {
            NameCharacter = nameCharacter;
            BaseArmor = baseArmor;
            BaseAttack = baseAttack;
            BaseHealth = baseHealth;            
        }

        public abstract void ReceiveRawDamageWithoutArmor(int rawDamage);
        public abstract void ReceiveDamageWithArmor(int damage);

        public abstract void Attack(Character characterToAttack);

    }
}
