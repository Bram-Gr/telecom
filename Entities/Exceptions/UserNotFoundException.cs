using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class UserNotFoundException: Exception
    {
        public UserNotFoundException(Guid userId) 
            : base($"The user with the id: {userId} cannot be found.")
        {
        }
    }
}
