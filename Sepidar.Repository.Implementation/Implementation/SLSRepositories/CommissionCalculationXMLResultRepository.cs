using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CommissionCalculationXMLResultRepository : Repository<CommissionCalculationXMLResult> , ICommissionCalculationXMLResultRepository
    {
        public CommissionCalculationXMLResultRepository(DataContext context) : base(context)
        {
        }
    }
}
