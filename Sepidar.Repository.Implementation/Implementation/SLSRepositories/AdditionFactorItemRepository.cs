using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class AdditionFactorItemRepository : Repository<AdditionFactorItem> , IAdditionFactorItemRepository
    {
        public AdditionFactorItemRepository(DataContext context) : base(context)
        {
        }
    }
}
