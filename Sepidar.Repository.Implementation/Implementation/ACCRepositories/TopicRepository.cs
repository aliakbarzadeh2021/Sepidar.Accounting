using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class TopicRepository : Repository<Topic> , ITopicRepository
    {
        public TopicRepository(DataContext context) : base(context)
        {
        }
    }
}
