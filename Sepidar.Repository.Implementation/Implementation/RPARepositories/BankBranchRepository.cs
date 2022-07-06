using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class BankBranchRepository : Repository<BankBranch> , IBankBranchRepository
    {
        public BankBranchRepository(DataContext context) : base(context)
        {
        }
    }
}
