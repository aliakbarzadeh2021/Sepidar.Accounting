using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CustomsClearanceRepository : Repository<CustomsClearance> , ICustomsClearanceRepository
    {
        public CustomsClearanceRepository(DataContext context) : base(context)
        {
        }
    }
}
