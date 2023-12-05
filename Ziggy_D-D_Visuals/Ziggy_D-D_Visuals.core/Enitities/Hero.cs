using Ziggy_D_D_Visuals.core.AbstractClasses;

namespace Ziggy_D_D_Visuals.core.Enitities
{
    public class Hero : Character
    {
        public byte Level { get; private set; }
        public  TotalStats TotalStats { get; set; }
        public Condition Condition { get; set; }
        public byte TotalMoveSteps { get; private set; }

        // list van items

        public Hero(string nameCharacter, int baseArmor, int baseAttack, int baseHealth, byte totalMoveSteps) : base(nameCharacter, baseArmor, baseAttack, baseHealth)
        {
            TotalMoveSteps = totalMoveSteps;
            Condition= new Condition();
            TotalStats = new TotalStats(baseHealth, baseAttack, baseArmor);
        }

        public override void Attack(Character characterToAttack)
        {
            throw new NotImplementedException();
        }

        public override void ReceiveDamageWithArmor(int damage)
        {
            if (damage < 0 ) throw new ArgumentOutOfRangeException("Damage","Damage can't be less then zero");
            TotalStats.TotalHealth -= damage;
            if (TotalStats.TotalHealth < 0 )
            {
                HeroIsDeath();
            }
        }

        private void HeroIsDeath()
        {
            TotalStats.TotalHealth = 0;
            Condition = new Condition("Death");
        }

        public override void ReceiveRawDamageWithoutArmor(int rawDamage)
        {
            throw new NotImplementedException();
        }
    }
}
