using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class EstablishmentCommunicationRepository : Repository<EstablishmentCommunication> , IEstablishmentCommunicationRepository
    {
        public EstablishmentCommunicationRepository(DataContext context) : base(context)
        {
        }
    }
}
