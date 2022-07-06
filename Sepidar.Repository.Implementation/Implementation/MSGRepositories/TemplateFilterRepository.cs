using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class TemplateFilterRepository : Repository<TemplateFilter> , ITemplateFilterRepository
    {
        public TemplateFilterRepository(DataContext context) : base(context)
        {
        }
    }
}
