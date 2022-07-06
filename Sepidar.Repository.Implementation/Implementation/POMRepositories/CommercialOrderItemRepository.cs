using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CommercialOrderItemRepository : Repository<CommercialOrderItem> , ICommercialOrderItemRepository
    {
        public CommercialOrderItemRepository(DataContext context) : base(context)
        {
        }
    }
}
