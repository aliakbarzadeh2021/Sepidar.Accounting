using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class DepreciationRuleRepository : Repository<DepreciationRule> , IDepreciationRuleRepository
    {
        public DepreciationRuleRepository(DataContext context) : base(context)
        {
        }
    }
}
