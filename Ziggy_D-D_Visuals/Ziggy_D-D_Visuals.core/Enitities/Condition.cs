namespace Ziggy_D_D_Visuals.core.Enitities
{
    public class Condition
    {
        public bool HasCondition { get; private set; }

        public string ConditionName { get; private set; }

        public Condition()
        {
           HasCondition = false;
        }
        public Condition(string conditionName)
        {
            HasCondition = true;
            ConditionName = conditionName;
        }
    }
}
