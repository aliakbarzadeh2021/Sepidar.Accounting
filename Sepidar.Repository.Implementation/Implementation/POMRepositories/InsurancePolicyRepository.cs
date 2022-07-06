using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InsurancePolicyRepository : Repository<InsurancePolicy> , IInsurancePolicyRepository
    {
        public InsurancePolicyRepository(DataContext context) : base(context)
        {
        }
    }
}
