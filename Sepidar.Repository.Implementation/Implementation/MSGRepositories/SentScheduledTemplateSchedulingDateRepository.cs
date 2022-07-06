using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class SentScheduledTemplateSchedulingDateRepository : Repository<SentScheduledTemplateSchedulingDate> , ISentScheduledTemplateSchedulingDateRepository
    {
        public SentScheduledTemplateSchedulingDateRepository(DataContext context) : base(context)
        {
        }
    }
}
