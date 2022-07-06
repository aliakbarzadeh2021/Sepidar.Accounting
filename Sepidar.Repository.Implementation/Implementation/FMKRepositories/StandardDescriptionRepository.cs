using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class StandardDescriptionRepository : Repository<StandardDescription> , IStandardDescriptionRepository
    {
        public StandardDescriptionRepository(DataContext context) : base(context)
        {
        }
    }
}
