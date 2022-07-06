using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ContractTypeRepository : Repository<ContractType> , IContractTypeRepository
    {
        public ContractTypeRepository(DataContext context) : base(context)
        {
        }
    }
}
