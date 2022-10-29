using KappaESB.Interfaces.Common;

namespace KappaESB.Core.Controllers
{
    internal class EsbController : INamedEntity
    {
        private List<string> _methods;
        public string Name { get; private set; }
        public string Description { get; private set; }
        public IReadOnlyList<string> Methods => _methods;

        /// <summary>
        /// Controller is used for grouping methods
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public EsbController(string name, string description = "")
        {
            Name = name;
            Description = description;
            _methods = new List<string>();
        }

        /// <summary>
        /// Add method to controller
        /// </summary>
        /// <param name="methodName"></param>
        public void AddMethod(string methodName)
        {
            _methods.Add(methodName);
        }
    }
}
