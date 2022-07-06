using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ProductFormulaRepository : Repository<ProductFormula> , IProductFormulaRepository
    {
        public ProductFormulaRepository(DataContext context) : base(context)
        {
        }
    }
}
