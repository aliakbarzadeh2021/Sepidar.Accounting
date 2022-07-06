using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class TransferRepository : Repository<Transfer> , ITransferRepository
    {
        public TransferRepository(DataContext context) : base(context)
        {
        }
    }
}
