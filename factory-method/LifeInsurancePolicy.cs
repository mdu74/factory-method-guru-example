namespace factory_method
{
    public class LifeInsurancePolicy : MainPolicy
    {
        public override IPolicy PolicyCreator()
        {
            return new LifeInsurance();
        }
    }
}