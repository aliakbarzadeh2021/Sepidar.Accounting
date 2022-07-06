using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class TemplateContactRepository : Repository<TemplateContact> , ITemplateContactRepository
    {
        public TemplateContactRepository(DataContext context) : base(context)
        {
        }
    }
}
