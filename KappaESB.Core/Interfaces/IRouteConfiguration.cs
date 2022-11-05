using KappaESB.Interfaces.Builders.Core;

namespace KappaESB.Core.Interfaces
{
    public interface IRouteConfiguration
    {
        void Configure(IEsbBuilder builder);
    }
}
