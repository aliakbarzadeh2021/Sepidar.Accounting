using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InvoiceReceiptInfoRepository : Repository<InvoiceReceiptInfo> , IInvoiceReceiptInfoRepository
    {
        public InvoiceReceiptInfoRepository(DataContext context) : base(context)
        {
        }
    }
}
