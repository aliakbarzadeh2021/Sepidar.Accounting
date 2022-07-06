using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class BranchRepository : Repository<Branch> , IBranchRepository
    {
        public BranchRepository(DataContext context) : base(context)
        {
        }
    }
}
