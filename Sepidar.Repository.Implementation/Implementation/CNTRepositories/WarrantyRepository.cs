using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class WarrantyRepository : Repository<Warranty> , IWarrantyRepository
    {
        public WarrantyRepository(DataContext context) : base(context)
        {
        }
    }
}
