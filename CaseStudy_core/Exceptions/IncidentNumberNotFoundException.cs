using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_core.Exceptions
{
    internal class IncidentNumberNotFoundException : Exception
    {
        public IncidentNumberNotFoundException()
        {

        }
        public IncidentNumberNotFoundException(string message) : base(message)
        {

        }
        public IncidentNumberNotFoundException(string message,Exception innerException): base(message, innerException)
        {

        }
    }
    
}
