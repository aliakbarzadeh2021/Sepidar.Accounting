using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class QuotationItemAdditionFactorRepository : Repository<QuotationItemAdditionFactor> , IQuotationItemAdditionFactorRepository
    {
        public QuotationItemAdditionFactorRepository(DataContext context) : base(context)
        {
        }
    }
}
