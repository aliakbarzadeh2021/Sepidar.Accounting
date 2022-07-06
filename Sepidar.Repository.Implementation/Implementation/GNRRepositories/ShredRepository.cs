using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ShredRepository : Repository<Shred> , IShredRepository
    {
        public ShredRepository(DataContext context) : base(context)
        {
        }
    }
}
