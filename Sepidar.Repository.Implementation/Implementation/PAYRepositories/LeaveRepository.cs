using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class LeaveRepository : Repository<Leave> , ILeaveRepository
    {
        public LeaveRepository(DataContext context) : base(context)
        {
        }
    }
}
