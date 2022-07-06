using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ItemAdditionFactorRepository : Repository<ItemAdditionFactor> , IItemAdditionFactorRepository
    {
        public ItemAdditionFactorRepository(DataContext context) : base(context)
        {
        }
    }
}
