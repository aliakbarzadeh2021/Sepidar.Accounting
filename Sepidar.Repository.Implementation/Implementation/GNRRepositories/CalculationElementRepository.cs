using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CalculationElementRepository : Repository<CalculationElement> , ICalculationElementRepository
    {
        public CalculationElementRepository(DataContext context) : base(context)
        {
        }
    }
}
