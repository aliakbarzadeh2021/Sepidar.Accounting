using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PaymentDraftRepository : Repository<PaymentDraft> , IPaymentDraftRepository
    {
        public PaymentDraftRepository(DataContext context) : base(context)
        {
        }
    }
}
