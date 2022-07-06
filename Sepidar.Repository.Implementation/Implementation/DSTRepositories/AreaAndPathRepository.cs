using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class AreaAndPathRepository : Repository<AreaAndPath> , IAreaAndPathRepository
    {
        public AreaAndPathRepository(DataContext context) : base(context)
        {
        }
    }
}
