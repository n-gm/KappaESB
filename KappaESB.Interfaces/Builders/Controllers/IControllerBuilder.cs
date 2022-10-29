using KappaESB.Interfaces.Common;
using KappaESB.Interfaces.Builders.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KappaESB.Interfaces.Builders.Controllers
{
    public interface IControllerBuilder : INamedEntity
    {
        public IEnumerable<IMethodBuilder> Methods { get; } 
    }
}
