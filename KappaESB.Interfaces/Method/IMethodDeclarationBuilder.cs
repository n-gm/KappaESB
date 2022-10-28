namespace KappaESB.Interfaces.Method
{
    public interface IMethodDeclarationBuilder
    {
        /// <summary>
        /// Declare basic info about method
        /// </summary>
        /// <param name="controllerName">Controller name</param>
        /// <param name="methodName">Method name</param>
        /// <returns></returns>
        IMethodBuilder DeclareMethod(string controllerName, string methodName);
    }
}
