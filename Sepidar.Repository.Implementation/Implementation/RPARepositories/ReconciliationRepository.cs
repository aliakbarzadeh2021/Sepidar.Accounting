using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReconciliationRepository : Repository<Reconciliation> , IReconciliationRepository
    {
        public ReconciliationRepository(DataContext context) : base(context)
        {
        }
    }
}
