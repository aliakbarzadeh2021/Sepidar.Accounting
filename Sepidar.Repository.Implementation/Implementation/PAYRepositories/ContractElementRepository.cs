using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ContractElementRepository : Repository<ContractElement> , IContractElementRepository
    {
        public ContractElementRepository(DataContext context) : base(context)
        {
        }
    }
}
