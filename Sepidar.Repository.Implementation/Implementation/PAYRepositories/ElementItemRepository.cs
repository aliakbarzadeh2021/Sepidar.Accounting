using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ElementItemRepository : Repository<ElementItem> , IElementItemRepository
    {
        public ElementItemRepository(DataContext context) : base(context)
        {
        }
    }
}
