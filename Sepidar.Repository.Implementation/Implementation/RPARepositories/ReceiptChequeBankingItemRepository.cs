using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReceiptChequeBankingItemRepository : Repository<ReceiptChequeBankingItem> , IReceiptChequeBankingItemRepository
    {
        public ReceiptChequeBankingItemRepository(DataContext context) : base(context)
        {
        }
    }
}
