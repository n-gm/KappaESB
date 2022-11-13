namespace KappaESB.Classes.Exceptions
{
    internal class PerformTypeMismatchException : Exception
    {
        public PerformTypeMismatchException(Type expectedType, Type actualType)
            : base($"Incorrect encapsulated type for Perform class. Expected: {expectedType.Name}, but was {actualType.Name}")
        {

        }
    }
}
