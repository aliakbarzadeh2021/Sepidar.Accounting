using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ChangeDepreciationMethodRepository : Repository<ChangeDepreciationMethod> , IChangeDepreciationMethodRepository
    {
        public ChangeDepreciationMethodRepository(DataContext context) : base(context)
        {
        }
    }
}
