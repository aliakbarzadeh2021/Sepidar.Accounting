using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReceiptHeaderRepository : Repository<ReceiptHeader> , IReceiptHeaderRepository
    {
        public ReceiptHeaderRepository(DataContext context) : base(context)
        {
        }
    }
}
