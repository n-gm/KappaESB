using KappaESB.Interfaces.Builders.Controllers;

namespace KappaESB.Core.Interfaces
{
    public interface IRouteConfiguration
    {
        void Configure(IControllerBuilder builder);
    }
}
