using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ContractWarrantyItemRepository : Repository<ContractWarrantyItem> , IContractWarrantyItemRepository
    {
        public ContractWarrantyItemRepository(DataContext context) : base(context)
        {
        }
    }
}
