namespace factory_method
{
    public class CarInsurance : IPolicy
    {
        public string Create() => "Car insurance";
    }
}