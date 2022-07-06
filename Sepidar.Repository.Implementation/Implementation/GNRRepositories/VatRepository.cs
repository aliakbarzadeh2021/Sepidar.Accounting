using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class VatRepository : Repository<Vat> , IVatRepository
    {
        public VatRepository(DataContext context) : base(context)
        {
        }
    }
}
