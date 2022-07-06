using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class FiscalYearRepository : Repository<FiscalYear> , IFiscalYearRepository
    {
        public FiscalYearRepository(DataContext context) : base(context)
        {
        }
    }
}
