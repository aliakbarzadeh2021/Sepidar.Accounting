using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CustomContactRepository : Repository<CustomContact> , ICustomContactRepository
    {
        public CustomContactRepository(DataContext context) : base(context)
        {
        }
    }
}
