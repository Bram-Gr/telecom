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
            : base($"The user with the id:{userId} does not have a plan with the id: {planId}")
        {
        }
    }
}
