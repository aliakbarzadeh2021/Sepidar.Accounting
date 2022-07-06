using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class HotDistributionSaleDocumentRepository : Repository<HotDistributionSaleDocument> , IHotDistributionSaleDocumentRepository
    {
        public HotDistributionSaleDocumentRepository(DataContext context) : base(context)
        {
        }
    }
}
