using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ContractSettlementRepository : Repository<ContractSettlement> , IContractSettlementRepository
    {
        public ContractSettlementRepository(DataContext context) : base(context)
        {
        }
    }
}
