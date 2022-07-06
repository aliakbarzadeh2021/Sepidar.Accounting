using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ConfigurationRepository : Repository<Configuration> , IConfigurationRepository
    {
        public ConfigurationRepository(DataContext context) : base(context)
        {
        }
    }
}
