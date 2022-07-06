using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CommunicationRepository : Repository<Communication> , ICommunicationRepository
    {
        public CommunicationRepository(DataContext context) : base(context)
        {
        }
    }
}
