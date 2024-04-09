using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class BillNotFoundException: Exception
    {
        public BillNotFoundException(Guid billId) 
            : base($"The bill with the id: {billId} cannot be found")

        {
        }
    }
}
