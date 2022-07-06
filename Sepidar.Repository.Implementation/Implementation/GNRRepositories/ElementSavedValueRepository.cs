using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ElementSavedValueRepository : Repository<ElementSavedValue> , IElementSavedValueRepository
    {
        public ElementSavedValueRepository(DataContext context) : base(context)
        {
        }
    }
}
