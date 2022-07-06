using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class BillRepository : Repository<Bill> , IBillRepository
    {
        public BillRepository(DataContext context) : base(context)
        {
        }
    }
}
