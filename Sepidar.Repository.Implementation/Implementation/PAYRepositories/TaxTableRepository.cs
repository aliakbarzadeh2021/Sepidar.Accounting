using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class TaxTableRepository : Repository<TaxTable> , ITaxTableRepository
    {
        public TaxTableRepository(DataContext context) : base(context)
        {
        }
    }
}
