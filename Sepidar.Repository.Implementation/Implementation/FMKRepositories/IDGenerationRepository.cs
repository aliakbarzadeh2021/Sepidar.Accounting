using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class IDGenerationRepository : Repository<IDGeneration> , IIDGenerationRepository
    {
        public IDGenerationRepository(DataContext context) : base(context)
        {
        }
    }
}
