using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class OpeningOperationRepository : Repository<OpeningOperation> , IOpeningOperationRepository
    {
        public OpeningOperationRepository(DataContext context) : base(context)
        {
        }
    }
}
