using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class FAQRepository : Repository<FAQ> , IFAQRepository
    {
        public FAQRepository(DataContext context) : base(context)
        {
        }
    }
}
