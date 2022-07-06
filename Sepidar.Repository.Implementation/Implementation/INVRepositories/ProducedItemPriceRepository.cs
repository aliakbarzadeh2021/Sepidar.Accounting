using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ProducedItemPriceRepository : Repository<ProducedItemPrice> , IProducedItemPriceRepository
    {
        public ProducedItemPriceRepository(DataContext context) : base(context)
        {
        }
    }
}
