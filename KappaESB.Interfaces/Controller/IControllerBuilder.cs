using KappaESB.Interfaces.Common;
using KappaESB.Interfaces.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KappaESB.Interfaces.Controller
{
    public interface IControllerBuilder : INamedBuilder
    {
        public IEnumerable<IMethodBuilder> Methods { get; } 
    }
}
