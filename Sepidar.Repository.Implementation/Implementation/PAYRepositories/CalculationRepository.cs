using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CalculationRepository : Repository<Calculation> , ICalculationRepository
    {
        public CalculationRepository(DataContext context) : base(context)
        {
        }
    }
}
