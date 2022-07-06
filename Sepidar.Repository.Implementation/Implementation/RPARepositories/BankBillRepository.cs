using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class BankBillRepository : Repository<BankBill> , IBankBillRepository
    {
        public BankBillRepository(DataContext context) : base(context)
        {
        }
    }
}
