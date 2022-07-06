using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class BillOfLoadingRepository : Repository<BillOfLoading> , IBillOfLoadingRepository
    {
        public BillOfLoadingRepository(DataContext context) : base(context)
        {
        }
    }
}
