using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PaymentHeaderRepository : Repository<PaymentHeader> , IPaymentHeaderRepository
    {
        public PaymentHeaderRepository(DataContext context) : base(context)
        {
        }
    }
}
