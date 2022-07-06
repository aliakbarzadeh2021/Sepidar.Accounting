using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class DeliveryLocationRepository : Repository<DeliveryLocation> , IDeliveryLocationRepository
    {
        public DeliveryLocationRepository(DataContext context) : base(context)
        {
        }
    }
}
