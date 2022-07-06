using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PaymentChequeHistoryRepository : Repository<PaymentChequeHistory> , IPaymentChequeHistoryRepository
    {
        public PaymentChequeHistoryRepository(DataContext context) : base(context)
        {
        }
    }
}
