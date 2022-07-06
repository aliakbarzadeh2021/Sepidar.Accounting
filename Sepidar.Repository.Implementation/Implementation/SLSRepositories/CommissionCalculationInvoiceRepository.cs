using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CommissionCalculationInvoiceRepository : Repository<CommissionCalculationInvoice> , ICommissionCalculationInvoiceRepository
    {
        public CommissionCalculationInvoiceRepository(DataContext context) : base(context)
        {
        }
    }
}
