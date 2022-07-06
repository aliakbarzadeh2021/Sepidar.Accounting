using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class VoucherRepository : Repository<Voucher> , IVoucherRepository
    {
        public VoucherRepository(DataContext context) : base(context)
        {
        }
    }
}
