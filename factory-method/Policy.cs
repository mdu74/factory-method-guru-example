namespace factory_method
{
    public class Policy
    {
        public void GetPolicy(PolicyType policyType)
        {
            if (policyType == PolicyType.CarInsurance) 
                ClientCode(new CarInsurancePolicy());
            if (policyType == PolicyType.LifeInsurance)
                ClientCode(new LifeInsurancePolicy());
        }

        public static void ClientCode(MainPolicy policy)
        {
            Console.WriteLine("Policy: I'm not aware of the main policy, but it still works.\n" + policy.GeneralPolicyCreator());
        }
    }
}