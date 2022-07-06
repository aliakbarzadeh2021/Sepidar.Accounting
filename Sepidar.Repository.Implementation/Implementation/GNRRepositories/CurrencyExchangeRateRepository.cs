using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CurrencyExchangeRateRepository : Repository<CurrencyExchangeRate> , ICurrencyExchangeRateRepository
    {
        public CurrencyExchangeRateRepository(DataContext context) : base(context)
        {
        }
    }
}
