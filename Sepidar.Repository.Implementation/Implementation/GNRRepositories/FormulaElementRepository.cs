using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class FormulaElementRepository : Repository<FormulaElement> , IFormulaElementRepository
    {
        public FormulaElementRepository(DataContext context) : base(context)
        {
        }
    }
}
