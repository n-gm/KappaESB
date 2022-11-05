using KappaESB.Interfaces.Common;
using KappaESB.Interfaces.Builders.Methods;

namespace KappaESB.Interfaces.Builders.Controllers
{
    public interface IControllerBuilder : INamedEntity
    {
        public IMethodBuilder DeclareMethod(string methodName, string methodDescription = "");
    }
}
