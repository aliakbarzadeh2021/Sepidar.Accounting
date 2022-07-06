using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class Message1Repository : Repository<Message1> , IMessage1Repository
    {
        public Message1Repository(DataContext context) : base(context)
        {
        }
    }
}
