using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class UserPhoneRepository : Repository<UserPhone> , IUserPhoneRepository
    {
        public UserPhoneRepository(DataContext context) : base(context)
        {
        }
    }
}
