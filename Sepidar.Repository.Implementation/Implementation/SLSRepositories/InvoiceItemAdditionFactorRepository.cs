using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InvoiceItemAdditionFactorRepository : Repository<InvoiceItemAdditionFactor> , IInvoiceItemAdditionFactorRepository
    {
        public InvoiceItemAdditionFactorRepository(DataContext context) : base(context)
        {
        }
    }
}
