using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IBillRepository
    {
       Task<IEnumerable<Bill>> GetAllBillsAsync(Guid userId, bool trackChanges);        
      
       Task<Bill> GetBillAsync(Guid userId, Guid id, bool trackChanges);

    }
}
