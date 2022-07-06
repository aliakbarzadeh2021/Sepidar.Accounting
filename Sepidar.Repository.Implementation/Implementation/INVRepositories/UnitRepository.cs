using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class UnitRepository : Repository<Unit> , IUnitRepository
    {
        public UnitRepository(DataContext context) : base(context)
        {
        }
    }
}
