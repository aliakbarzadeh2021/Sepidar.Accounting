using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class GuaranteeRepository : Repository<Guarantee> , IGuaranteeRepository
    {
        public GuaranteeRepository(DataContext context) : base(context)
        {
        }
    }
}
