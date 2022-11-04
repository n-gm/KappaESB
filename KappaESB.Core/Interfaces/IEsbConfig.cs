using KappaESB.Core.Config;
using KappaESB.Interfaces.Builders.Controllers;

namespace KappaESB.Core.Interfaces
{
    public interface IEsbConfig
    {
        /// <summary>
        /// Create new instance of config
        /// </summary>
        /// <returns></returns>
        static IEsbConfig Create() => new EsbConfig(); 
        /// <summary>
        /// Type of queue that is used to route between endpoints
        /// </summary>
        QueueType BusQueueType { get; set; }
        /// <summary>
        /// Connection string for selected queue
        /// </summary>
        string? QueueConnectionString { get; set; }
        /// <summary>
        /// Add configuration for methods. Can be invoked multiple times for different configurations, all configs added to main system config.
        /// </summary>
        /// <typeparam name="ConfigurationType">Must have parameterless constructor</typeparam>
        /// <returns></returns>
        IEsbConfig AddRouteConfiguration<ConfigurationType>() where ConfigurationType : IRouteConfiguration, new();
        /// <summary>
        /// Add configuration for methods. Can be invoked multiple times for different configurations, all configs added to main system config.
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        IEsbConfig AddRouteConfiguration(IRouteConfiguration config);
        /// <summary>
        /// Add configuration for methods. Can be invoked multiple times for different configurations, all configs added to main system config.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        IEsbConfig AddRouteConfiguration(Action<IControllerBuilder> builder);
    }
}
