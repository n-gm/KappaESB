using KappaESB.Interfaces.Common;
using KappaESB.Interfaces.Builders.Methods;

namespace KappaESB.Interfaces.Builders.Controllers
{
    public interface IControllerBuilder : INamedEntity
    {
        public IEnumerable<IMethodBuilder> Methods { get; } 
    }
}
