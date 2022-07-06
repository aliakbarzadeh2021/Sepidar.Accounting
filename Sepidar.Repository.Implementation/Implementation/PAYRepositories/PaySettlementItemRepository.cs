using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PaySettlementItemRepository : Repository<PaySettlementItem> , IPaySettlementItemRepository
    {
        public PaySettlementItemRepository(DataContext context) : base(context)
        {
        }
    }
}
