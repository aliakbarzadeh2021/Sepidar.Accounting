using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReconciliationBankItemRepository : Repository<ReconciliationBankItem> , IReconciliationBankItemRepository
    {
        public ReconciliationBankItemRepository(DataContext context) : base(context)
        {
        }
    }
}
