using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class AccountTopicRepository : Repository<AccountTopic> , IAccountTopicRepository
    {
        public AccountTopicRepository(DataContext context) : base(context)
        {
        }
    }
}
