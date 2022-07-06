using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PerformaRepository : Repository<Performa> , IPerformaRepository
    {
        public PerformaRepository(DataContext context) : base(context)
        {
        }
    }
}
