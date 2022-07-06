using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class KeywordRepository : Repository<Keyword> , IKeywordRepository
    {
        public KeywordRepository(DataContext context) : base(context)
        {
        }
    }
}
