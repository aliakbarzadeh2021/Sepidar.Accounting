using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InboxRepository : Repository<Inbox> , IInboxRepository
    {
        public InboxRepository(DataContext context) : base(context)
        {
        }
    }
}
