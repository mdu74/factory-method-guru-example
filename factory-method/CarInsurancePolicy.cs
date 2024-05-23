namespace factory_method
{
    public class CarInsurancePolicy : MainPolicy
    {
        public override IPolicy PolicyCreator()
        {
            return new CarInsurance();
        }
    }
}