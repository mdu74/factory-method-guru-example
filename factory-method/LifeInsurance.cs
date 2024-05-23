namespace factory_method
{
    public class LifeInsurance : IPolicy
    {
        public string Create() => "Life insurance";
    }
}