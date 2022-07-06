using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class OutgoingMessageRepository : Repository<OutgoingMessage> , IOutgoingMessageRepository
    {
        public OutgoingMessageRepository(DataContext context) : base(context)
        {
        }
    }
}
