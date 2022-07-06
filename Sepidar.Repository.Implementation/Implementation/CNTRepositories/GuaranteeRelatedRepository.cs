using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class GuaranteeRelatedRepository : Repository<GuaranteeRelated> , IGuaranteeRelatedRepository
    {
        public GuaranteeRelatedRepository(DataContext context) : base(context)
        {
        }
    }
}
