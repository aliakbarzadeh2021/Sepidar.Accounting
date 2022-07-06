using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CurrencyRepository : Repository<Currency> , ICurrencyRepository
    {
        public CurrencyRepository(DataContext context) : base(context)
        {
        }
    }
}
