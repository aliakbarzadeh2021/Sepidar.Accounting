using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class TemplateRepository : Repository<Template> , ITemplateRepository
    {
        public TemplateRepository(DataContext context) : base(context)
        {
        }
    }
}
