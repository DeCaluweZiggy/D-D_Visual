namespace Ziggy_D_D_Visuals.core.Enitities
{
    public class TotalStats
    {
        public int TotalHealth { get;  set; }
        public int TotalAttack { get;  set; }
        public int TotalArmor { get;   set; }

        public TotalStats(int health, int attack, int armor)
        {
            TotalArmor = armor;
            TotalHealth = health;
            TotalAttack = attack;
        }
    }
}
