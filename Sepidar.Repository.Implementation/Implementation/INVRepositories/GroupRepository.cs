using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class GroupRepository : Repository<Group> , IGroupRepository
    {
        public GroupRepository(DataContext context) : base(context)
        {
        }
    }
}
