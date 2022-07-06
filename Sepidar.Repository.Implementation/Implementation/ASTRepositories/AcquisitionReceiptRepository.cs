using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class AcquisitionReceiptRepository : Repository<AcquisitionReceipt> , IAcquisitionReceiptRepository
    {
        public AcquisitionReceiptRepository(DataContext context) : base(context)
        {
        }
    }
}
