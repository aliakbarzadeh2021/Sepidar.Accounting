using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class BankBillItemRepository : Repository<BankBillItem> , IBankBillItemRepository
    {
        public BankBillItemRepository(DataContext context) : base(context)
        {
        }
    }
}
