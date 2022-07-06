using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class UserReportsInvisibleRepository : Repository<UserReportsInvisible> , IUserReportsInvisibleRepository
    {
        public UserReportsInvisibleRepository(DataContext context) : base(context)
        {
        }
    }
}
