using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class StatusReceiptItemRepository : Repository<StatusReceiptItem> , IStatusReceiptItemRepository
    {
        public StatusReceiptItemRepository(DataContext context) : base(context)
        {
        }
    }
}
