using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class QuotationRepository : Repository<Quotation> , IQuotationRepository
    {
        public QuotationRepository(DataContext context) : base(context)
        {
        }
    }
}
