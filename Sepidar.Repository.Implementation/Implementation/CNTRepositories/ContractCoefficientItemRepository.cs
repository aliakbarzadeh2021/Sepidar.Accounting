using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ContractCoefficientItemRepository : Repository<ContractCoefficientItem> , IContractCoefficientItemRepository
    {
        public ContractCoefficientItemRepository(DataContext context) : base(context)
        {
        }
    }
}
