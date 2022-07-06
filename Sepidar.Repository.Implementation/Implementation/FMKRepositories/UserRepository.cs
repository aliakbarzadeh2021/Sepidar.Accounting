using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class UserRepository : Repository<User> , IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {
        }
    }
}
