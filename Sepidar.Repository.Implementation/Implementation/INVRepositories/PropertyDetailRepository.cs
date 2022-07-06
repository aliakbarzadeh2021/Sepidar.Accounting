using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PropertyDetailRepository : Repository<PropertyDetail> , IPropertyDetailRepository
    {
        public PropertyDetailRepository(DataContext context) : base(context)
        {
        }
    }
}
