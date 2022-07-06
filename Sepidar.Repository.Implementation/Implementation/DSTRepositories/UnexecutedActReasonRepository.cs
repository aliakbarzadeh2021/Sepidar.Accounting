using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class UnexecutedActReasonRepository : Repository<UnexecutedActReason> , IUnexecutedActReasonRepository
    {
        public UnexecutedActReasonRepository(DataContext context) : base(context)
        {
        }
    }
}
