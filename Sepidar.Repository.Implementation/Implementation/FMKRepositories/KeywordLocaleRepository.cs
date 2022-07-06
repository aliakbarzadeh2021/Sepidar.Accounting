using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class KeywordLocaleRepository : Repository<KeywordLocale> , IKeywordLocaleRepository
    {
        public KeywordLocaleRepository(DataContext context) : base(context)
        {
        }
    }
}
