using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CostPartRepository : Repository<CostPart> , ICostPartRepository
    {
        public CostPartRepository(DataContext context) : base(context)
        {
        }
    }
}
