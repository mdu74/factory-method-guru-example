namespace factory_method
{
    public class Policy
    {
        public void GetPolicy(PolicyType policyType)
        {
            if (policyType == PolicyType.CarInsurance) 
                TriggerPolicy(new CarInsurancePolicy());
            if (policyType == PolicyType.LifeInsurance)
                TriggerPolicy(new LifeInsurancePolicy());
        }

        public static void TriggerPolicy(MainPolicy policy)
        {
            Console.WriteLine("Policy: I'm not aware of the main policy, but it still works.\n" + policy.GeneralPolicyCreator());
        }
    }
}
