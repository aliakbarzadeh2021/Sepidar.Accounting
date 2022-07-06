using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CustomContactPhoneRepository : Repository<CustomContactPhone> , ICustomContactPhoneRepository
    {
        public CustomContactPhoneRepository(DataContext context) : base(context)
        {
        }
    }
}
