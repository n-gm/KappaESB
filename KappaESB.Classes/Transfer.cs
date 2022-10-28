using KappaESB.Classes.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KappaESB.Classes
{
    public class Transfer
    {
        public TransferMetadata Metadata { get; set; }
        public RequestData Request { get; set; }
        public object Response { get; set; }
    }
}
