using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class GLVoucherRepository : Repository<GLVoucher> , IGLVoucherRepository
    {
        public GLVoucherRepository(DataContext context) : base(context)
        {
        }
    }
}
