using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReceiptDraftRepository : Repository<ReceiptDraft> , IReceiptDraftRepository
    {
        public ReceiptDraftRepository(DataContext context) : base(context)
        {
        }
    }
}
