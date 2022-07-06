using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class DebitCreditNoteItemRepository : Repository<DebitCreditNoteItem> , IDebitCreditNoteItemRepository
    {
        public DebitCreditNoteItemRepository(DataContext context) : base(context)
        {
        }
    }
}
