using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PaymentChequeRepository : Repository<PaymentCheque> , IPaymentChequeRepository
    {
        public PaymentChequeRepository(DataContext context) : base(context)
        {
        }
    }
}
