namespace KappaESB.Classes.Exceptions
{
    public class MethodAlreadyDeclaredException : Exception
    {
        public string MethodName { get; set; }
        public int Version { get; set; }

        public MethodAlreadyDeclaredException(string methodName, int version)
            : base($"Method '{methodName}' with version {version} already declared. Check ESB config.")
        {
            MethodName = methodName;
            Version = version;
        }
    }
}
