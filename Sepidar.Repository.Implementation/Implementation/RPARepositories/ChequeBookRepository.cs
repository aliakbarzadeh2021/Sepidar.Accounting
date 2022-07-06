using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ChequeBookRepository : Repository<ChequeBook> , IChequeBookRepository
    {
        public ChequeBookRepository(DataContext context) : base(context)
        {
        }
    }
}
