using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class TaxGroupRepository : Repository<TaxGroup> , ITaxGroupRepository
    {
        public TaxGroupRepository(DataContext context) : base(context)
        {
        }
    }
}
