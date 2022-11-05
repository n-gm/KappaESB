using KappaESB.Interfaces.Builders.Controllers;

namespace KappaESB.Interfaces.Builders.Core
{
    public interface IEsbBuilder
    {
        /// <summary>
        /// Declare controller
        /// </summary>
        /// <param name="controllerName"></param>
        /// <param name="controllerDescription"></param>
        /// <returns></returns>
        public IControllerBuilder DeclareController(string controllerName, string controllerDescription = "");
    }
}
