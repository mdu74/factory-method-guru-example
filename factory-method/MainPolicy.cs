namespace factory_method
{
    public abstract class MainPolicy
    {
        public abstract IPolicy PolicyCreator();
        public string GeneralPolicyCreator()
        {
            var policy = PolicyCreator();
            var result = "General Policy Creator: The same policy's code has just worked with " + policy.Create();

            return result;
        }
    }
}