using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ElementRepository : Repository<Element> , IElementRepository
    {
        public ElementRepository(DataContext context) : base(context)
        {
        }
    }
}
