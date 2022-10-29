namespace KappaESB.Core.Methods
{
    /// <summary>
    /// Actual route of message
    /// </summary>
    internal class EsbMethodRoute
    {
        public Guid Id { get; private set; }
        public string MethodName { get; private set; }
        public int Stage { get; private set; }

        public EsbMethodRoute(string methodName)
        {
            Id = Guid.NewGuid();
            MethodName = methodName;
            Stage = 0;
        }
    }
}
