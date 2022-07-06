using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class VoucherItemTrackingRepository : Repository<VoucherItemTracking> , IVoucherItemTrackingRepository
    {
        public VoucherItemTrackingRepository(DataContext context) : base(context)
        {
        }
    }
}
