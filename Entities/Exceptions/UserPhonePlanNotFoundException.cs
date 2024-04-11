using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class UserPhonePlanNotFoundException: Exception
    {
        public UserPhonePlanNotFoundException(Guid userId, Guid planId)
            : base($"UserPhonePlan record with id planId:{planId}, userId:{userId} not found")
        {
        }
    }
}
