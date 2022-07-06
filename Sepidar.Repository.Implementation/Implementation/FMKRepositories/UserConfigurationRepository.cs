using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class UserConfigurationRepository : Repository<UserConfiguration> , IUserConfigurationRepository
    {
        public UserConfigurationRepository(DataContext context) : base(context)
        {
        }
    }
}
