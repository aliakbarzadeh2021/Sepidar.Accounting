using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class RefundChequeRepository : Repository<RefundCheque> , IRefundChequeRepository
    {
        public RefundChequeRepository(DataContext context) : base(context)
        {
        }
    }
}
