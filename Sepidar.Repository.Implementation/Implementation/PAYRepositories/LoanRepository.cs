using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class LoanRepository : Repository<Loan> , ILoanRepository
    {
        public LoanRepository(DataContext context) : base(context)
        {
        }
    }
}
