using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class AdditionFactorRepository : Repository<AdditionFactor> , IAdditionFactorRepository
    {
        public AdditionFactorRepository(DataContext context) : base(context)
        {
        }
    }
}
