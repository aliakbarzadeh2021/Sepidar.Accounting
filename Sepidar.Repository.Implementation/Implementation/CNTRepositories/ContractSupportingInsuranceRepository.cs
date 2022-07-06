using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ContractSupportingInsuranceRepository : Repository<ContractSupportingInsurance> , IContractSupportingInsuranceRepository
    {
        public ContractSupportingInsuranceRepository(DataContext context) : base(context)
        {
        }
    }
}
