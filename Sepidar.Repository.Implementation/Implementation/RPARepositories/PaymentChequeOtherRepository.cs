using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PaymentChequeOtherRepository : Repository<PaymentChequeOther> , IPaymentChequeOtherRepository
    {
        public PaymentChequeOtherRepository(DataContext context) : base(context)
        {
        }
    }
}
