using KappaESB.Interfaces.Builders.Controllers;
using KappaESB.Interfaces.Common;

namespace KappaESB.Core.Controllers
{
    internal class EsbController : INamedEntity
    {
        private List<string> _methods;
        public string Name { get; private set; }
        public string Description { get; private set; }

        /// <summary>
        /// Controller is used for grouping methods
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public EsbController(string name, string description = "")
        {
            Name = name;
            Description = description;
        }
    }
}
