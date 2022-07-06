using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class GroupingRepository : Repository<Grouping> , IGroupingRepository
    {
        public GroupingRepository(DataContext context) : base(context)
        {
        }
    }
}
