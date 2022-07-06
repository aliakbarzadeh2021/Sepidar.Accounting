using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CalculationFormulaRepository : Repository<CalculationFormula> , ICalculationFormulaRepository
    {
        public CalculationFormulaRepository(DataContext context) : base(context)
        {
        }
    }
}
