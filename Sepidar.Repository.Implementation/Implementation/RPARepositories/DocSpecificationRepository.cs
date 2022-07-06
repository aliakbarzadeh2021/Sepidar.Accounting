using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class DocSpecificationRepository : Repository<DocSpecification> , IDocSpecificationRepository
    {
        public DocSpecificationRepository(DataContext context) : base(context)
        {
        }
    }
}
