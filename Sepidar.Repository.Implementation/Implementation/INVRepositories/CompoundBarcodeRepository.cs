using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CompoundBarcodeRepository : Repository<CompoundBarcode> , ICompoundBarcodeRepository
    {
        public CompoundBarcodeRepository(DataContext context) : base(context)
        {
        }
    }
}
