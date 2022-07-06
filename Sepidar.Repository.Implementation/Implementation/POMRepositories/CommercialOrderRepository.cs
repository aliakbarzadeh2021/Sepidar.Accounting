using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CommercialOrderRepository : Repository<CommercialOrder> , ICommercialOrderRepository
    {
        public CommercialOrderRepository(DataContext context) : base(context)
        {
        }
    }
}
