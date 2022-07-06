using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class UserAccessRepository : Repository<UserAccess> , IUserAccessRepository
    {
        public UserAccessRepository(DataContext context) : base(context)
        {
        }
    }
}
