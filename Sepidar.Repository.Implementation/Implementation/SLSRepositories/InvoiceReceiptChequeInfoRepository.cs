using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InvoiceReceiptChequeInfoRepository : Repository<InvoiceReceiptChequeInfo> , IInvoiceReceiptChequeInfoRepository
    {
        public InvoiceReceiptChequeInfoRepository(DataContext context) : base(context)
        {
        }
    }
}
