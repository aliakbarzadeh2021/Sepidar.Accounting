using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReceiptChequeHistoryRepository : Repository<ReceiptChequeHistory> , IReceiptChequeHistoryRepository
    {
        public ReceiptChequeHistoryRepository(DataContext context) : base(context)
        {
        }
    }
}
