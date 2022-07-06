using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PaymentChequeBankingRepository : Repository<PaymentChequeBanking> , IPaymentChequeBankingRepository
    {
        public PaymentChequeBankingRepository(DataContext context) : base(context)
        {
        }
    }
}
