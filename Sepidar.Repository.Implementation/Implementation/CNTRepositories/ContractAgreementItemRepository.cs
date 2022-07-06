using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ContractAgreementItemRepository : Repository<ContractAgreementItem> , IContractAgreementItemRepository
    {
        public ContractAgreementItemRepository(DataContext context) : base(context)
        {
        }
    }
}
