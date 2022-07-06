using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PayContractRepository : Repository<PayContract> , IPayContractRepository
    {
        public PayContractRepository(DataContext context) : base(context)
        {
        }
    }
}
