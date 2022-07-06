using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ContractEmployerMaterialsItemRepository : Repository<ContractEmployerMaterialsItem> , IContractEmployerMaterialsItemRepository
    {
        public ContractEmployerMaterialsItemRepository(DataContext context) : base(context)
        {
        }
    }
}
