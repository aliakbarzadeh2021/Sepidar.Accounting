using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class MessageContactRepository : Repository<MessageContact> , IMessageContactRepository
    {
        public MessageContactRepository(DataContext context) : base(context)
        {
        }
    }
}
