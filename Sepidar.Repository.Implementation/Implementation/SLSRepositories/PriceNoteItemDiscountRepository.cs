using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PriceNoteItemDiscountRepository : Repository<PriceNoteItemDiscount> , IPriceNoteItemDiscountRepository
    {
        public PriceNoteItemDiscountRepository(DataContext context) : base(context)
        {
        }
    }
}
