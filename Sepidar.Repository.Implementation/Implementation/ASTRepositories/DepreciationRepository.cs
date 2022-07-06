using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class DepreciationRepository : Repository<Depreciation> , IDepreciationRepository
    {
        public DepreciationRepository(DataContext context) : base(context)
        {
        }
    }
}
