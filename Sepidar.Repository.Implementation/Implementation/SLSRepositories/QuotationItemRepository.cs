using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class QuotationItemRepository : Repository<QuotationItem> , IQuotationItemRepository
    {
        public QuotationItemRepository(DataContext context) : base(context)
        {
        }
    }
}
