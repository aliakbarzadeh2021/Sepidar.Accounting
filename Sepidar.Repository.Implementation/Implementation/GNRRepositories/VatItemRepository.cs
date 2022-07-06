using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class VatItemRepository : Repository<VatItem> , IVatItemRepository
    {
        public VatItemRepository(DataContext context) : base(context)
        {
        }
    }
}
