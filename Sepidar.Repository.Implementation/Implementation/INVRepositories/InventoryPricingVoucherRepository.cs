using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InventoryPricingVoucherRepository : Repository<InventoryPricingVoucher> , IInventoryPricingVoucherRepository
    {
        public InventoryPricingVoucherRepository(DataContext context) : base(context)
        {
        }
    }
}
