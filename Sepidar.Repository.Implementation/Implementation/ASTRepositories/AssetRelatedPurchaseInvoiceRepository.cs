using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class AssetRelatedPurchaseInvoiceRepository : Repository<AssetRelatedPurchaseInvoice> , IAssetRelatedPurchaseInvoiceRepository
    {
        public AssetRelatedPurchaseInvoiceRepository(DataContext context) : base(context)
        {
        }
    }
}
