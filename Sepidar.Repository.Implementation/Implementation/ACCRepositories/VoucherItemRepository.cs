using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class VoucherItemRepository : Repository<VoucherItem> , IVoucherItemRepository
    {
        public VoucherItemRepository(DataContext context) : base(context)
        {
        }
    }
}
