using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class TemplateEventRepository : Repository<TemplateEvent> , ITemplateEventRepository
    {
        public TemplateEventRepository(DataContext context) : base(context)
        {
        }
    }
}
