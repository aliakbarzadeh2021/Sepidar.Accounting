using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class EliminationRepository : Repository<Elimination> , IEliminationRepository
    {
        public EliminationRepository(DataContext context) : base(context)
        {
        }
    }
}
