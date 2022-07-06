using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CostStatementRepository : Repository<CostStatement> , ICostStatementRepository
    {
        public CostStatementRepository(DataContext context) : base(context)
        {
        }
    }
}
