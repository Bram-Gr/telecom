using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Repository
{
    public class BillRepository : RepositoryBase<Bill>, IBillRepository
    {

        public BillRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public Task<IEnumerable<Bill>> GetAllBillsAsync(Guid userId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Bill> GetBillAsync(Guid userId, Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
