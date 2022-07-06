using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReturnOrderItemAdditionFactorRepository : Repository<ReturnOrderItemAdditionFactor> , IReturnOrderItemAdditionFactorRepository
    {
        public ReturnOrderItemAdditionFactorRepository(DataContext context) : base(context)
        {
        }
    }
}
