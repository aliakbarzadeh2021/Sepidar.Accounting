using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PosRepository : Repository<Pos> , IPosRepository
    {
        public PosRepository(DataContext context) : base(context)
        {
        }
    }
}
