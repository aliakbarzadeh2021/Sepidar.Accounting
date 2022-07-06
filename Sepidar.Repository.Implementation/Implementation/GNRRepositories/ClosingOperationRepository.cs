using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ClosingOperationRepository : Repository<ClosingOperation> , IClosingOperationRepository
    {
        public ClosingOperationRepository(DataContext context) : base(context)
        {
        }
    }
}
