using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class RefundChequeItemRepository : Repository<RefundChequeItem> , IRefundChequeItemRepository
    {
        public RefundChequeItemRepository(DataContext context) : base(context)
        {
        }
    }
}
