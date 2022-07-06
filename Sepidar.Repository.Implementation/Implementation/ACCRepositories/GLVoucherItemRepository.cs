using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class GLVoucherItemRepository : Repository<GLVoucherItem> , IGLVoucherItemRepository
    {
        public GLVoucherItemRepository(DataContext context) : base(context)
        {
        }
    }
}
