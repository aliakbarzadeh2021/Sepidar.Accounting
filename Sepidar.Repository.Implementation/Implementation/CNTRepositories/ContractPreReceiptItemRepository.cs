using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ContractPreReceiptItemRepository : Repository<ContractPreReceiptItem> , IContractPreReceiptItemRepository
    {
        public ContractPreReceiptItemRepository(DataContext context) : base(context)
        {
        }
    }
}
