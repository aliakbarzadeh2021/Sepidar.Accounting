using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InsurancePolicyItemRepository : Repository<InsurancePolicyItem> , IInsurancePolicyItemRepository
    {
        public InsurancePolicyItemRepository(DataContext context) : base(context)
        {
        }
    }
}
