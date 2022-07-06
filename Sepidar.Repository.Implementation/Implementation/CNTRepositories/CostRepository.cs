using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CostRepository : Repository<Cost> , ICostRepository
    {
        public CostRepository(DataContext context) : base(context)
        {
        }
    }
}
