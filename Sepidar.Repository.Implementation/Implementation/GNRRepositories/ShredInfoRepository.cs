using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ShredInfoRepository : Repository<ShredInfo> , IShredInfoRepository
    {
        public ShredInfoRepository(DataContext context) : base(context)
        {
        }
    }
}
