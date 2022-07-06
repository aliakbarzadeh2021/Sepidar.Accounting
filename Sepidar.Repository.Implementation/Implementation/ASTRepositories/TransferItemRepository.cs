using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class TransferItemRepository : Repository<TransferItem> , ITransferItemRepository
    {
        public TransferItemRepository(DataContext context) : base(context)
        {
        }
    }
}
