using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CommunicationConfigurationRepository : Repository<CommunicationConfiguration> , ICommunicationConfigurationRepository
    {
        public CommunicationConfigurationRepository(DataContext context) : base(context)
        {
        }
    }
}
