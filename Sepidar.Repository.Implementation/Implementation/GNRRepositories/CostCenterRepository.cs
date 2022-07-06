using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CostCenterRepository : Repository<CostCenter> , ICostCenterRepository
    {
        public CostCenterRepository(DataContext context) : base(context)
        {
        }
    }
}
