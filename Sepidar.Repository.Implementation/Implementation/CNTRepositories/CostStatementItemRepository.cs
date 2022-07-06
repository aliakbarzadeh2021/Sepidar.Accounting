using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CostStatementItemRepository : Repository<CostStatementItem> , ICostStatementItemRepository
    {
        public CostStatementItemRepository(DataContext context) : base(context)
        {
        }
    }
}
