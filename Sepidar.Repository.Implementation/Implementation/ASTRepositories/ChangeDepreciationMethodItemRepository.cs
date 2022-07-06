using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ChangeDepreciationMethodItemRepository : Repository<ChangeDepreciationMethodItem> , IChangeDepreciationMethodItemRepository
    {
        public ChangeDepreciationMethodItemRepository(DataContext context) : base(context)
        {
        }
    }
}
