using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ContractCompromiseItemRepository : Repository<ContractCompromiseItem> , IContractCompromiseItemRepository
    {
        public ContractCompromiseItemRepository(DataContext context) : base(context)
        {
        }
    }
}
