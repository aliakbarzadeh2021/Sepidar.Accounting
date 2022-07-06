using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class TemplateSchedulingRepository : Repository<TemplateScheduling> , ITemplateSchedulingRepository
    {
        public TemplateSchedulingRepository(DataContext context) : base(context)
        {
        }
    }
}
