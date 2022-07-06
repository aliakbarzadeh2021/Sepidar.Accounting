using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PropertyRepository : Repository<Property> , IPropertyRepository
    {
        public PropertyRepository(DataContext context) : base(context)
        {
        }
    }
}
