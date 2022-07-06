using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class GuaranteeOperationRepository : Repository<GuaranteeOperation> , IGuaranteeOperationRepository
    {
        public GuaranteeOperationRepository(DataContext context) : base(context)
        {
        }
    }
}
