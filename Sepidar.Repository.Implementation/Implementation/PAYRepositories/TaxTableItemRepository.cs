using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class TaxTableItemRepository : Repository<TaxTableItem> , ITaxTableItemRepository
    {
        public TaxTableItemRepository(DataContext context) : base(context)
        {
        }
    }
}
