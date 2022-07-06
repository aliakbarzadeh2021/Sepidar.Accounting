using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class DebtCollectionListRepository : Repository<DebtCollectionList> , IDebtCollectionListRepository
    {
        public DebtCollectionListRepository(DataContext context) : base(context)
        {
        }
    }
}
