using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PaymentChequeBankingItemRepository : Repository<PaymentChequeBankingItem> , IPaymentChequeBankingItemRepository
    {
        public PaymentChequeBankingItemRepository(DataContext context) : base(context)
        {
        }
    }
}
