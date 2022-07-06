using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ContractPriceListRepository : Repository<ContractPriceList> , IContractPriceListRepository
    {
        public ContractPriceListRepository(DataContext context) : base(context)
        {
        }
    }
}
