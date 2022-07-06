using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class TenderRepository : Repository<Tender> , ITenderRepository
    {
        public TenderRepository(DataContext context) : base(context)
        {
        }
    }
}
