using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReturnReasonRepository : Repository<ReturnReason> , IReturnReasonRepository
    {
        public ReturnReasonRepository(DataContext context) : base(context)
        {
        }
    }
}
