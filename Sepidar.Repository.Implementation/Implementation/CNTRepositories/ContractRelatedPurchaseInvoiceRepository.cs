using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ContractRelatedPurchaseInvoiceRepository : Repository<ContractRelatedPurchaseInvoice> , IContractRelatedPurchaseInvoiceRepository
    {
        public ContractRelatedPurchaseInvoiceRepository(DataContext context) : base(context)
        {
        }
    }
}
