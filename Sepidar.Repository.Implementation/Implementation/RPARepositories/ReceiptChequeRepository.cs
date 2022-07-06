using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReceiptChequeRepository : Repository<ReceiptCheque> , IReceiptChequeRepository
    {
        public ReceiptChequeRepository(DataContext context) : base(context)
        {
        }
    }
}
