using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class QuickBarRepository : Repository<QuickBar> , IQuickBarRepository
    {
        public QuickBarRepository(DataContext context) : base(context)
        {
        }
    }
}
