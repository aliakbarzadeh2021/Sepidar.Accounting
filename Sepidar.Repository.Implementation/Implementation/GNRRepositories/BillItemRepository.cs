using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class BillItemRepository : Repository<BillItem> , IBillItemRepository
    {
        public BillItemRepository(DataContext context) : base(context)
        {
        }
    }
}
