using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class AcquisitionReceiptItemRepository : Repository<AcquisitionReceiptItem> , IAcquisitionReceiptItemRepository
    {
        public AcquisitionReceiptItemRepository(DataContext context) : base(context)
        {
        }
    }
}
