using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PosSettlementReceiptRepository : Repository<PosSettlementReceipt> , IPosSettlementReceiptRepository
    {
        public PosSettlementReceiptRepository(DataContext context) : base(context)
        {
        }
    }
}
