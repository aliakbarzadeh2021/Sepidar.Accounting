using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PaySettlementRepository : Repository<PaySettlement> , IPaySettlementRepository
    {
        public PaySettlementRepository(DataContext context) : base(context)
        {
        }
    }
}
