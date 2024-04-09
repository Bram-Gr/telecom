using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class PhonePlanNotFoundException : Exception
    {
        public PhonePlanNotFoundException(Guid planId) 
            : base($"The phone plane with the id: {planId} cannot be found")
        {
        }
    }
}
