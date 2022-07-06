using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReceiptChequeBankingRepository : Repository<ReceiptChequeBanking> , IReceiptChequeBankingRepository
    {
        public ReceiptChequeBankingRepository(DataContext context) : base(context)
        {
        }
    }
}
