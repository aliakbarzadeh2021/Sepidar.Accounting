using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ContractRepository : Repository<Contract> , IContractRepository
    {
        public ContractRepository(DataContext context) : base(context)
        {
        }
    }
}
