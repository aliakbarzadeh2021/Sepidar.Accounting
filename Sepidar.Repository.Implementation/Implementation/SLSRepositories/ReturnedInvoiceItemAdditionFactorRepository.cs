using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReturnedInvoiceItemAdditionFactorRepository : Repository<ReturnedInvoiceItemAdditionFactor> , IReturnedInvoiceItemAdditionFactorRepository
    {
        public ReturnedInvoiceItemAdditionFactorRepository(DataContext context) : base(context)
        {
        }
    }
}
