using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CoefficientRepository : Repository<Coefficient> , ICoefficientRepository
    {
        public CoefficientRepository(DataContext context) : base(context)
        {
        }
    }
}
