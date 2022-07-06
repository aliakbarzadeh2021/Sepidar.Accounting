using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class EliminationItemRepository : Repository<EliminationItem> , IEliminationItemRepository
    {
        public EliminationItemRepository(DataContext context) : base(context)
        {
        }
    }
}
