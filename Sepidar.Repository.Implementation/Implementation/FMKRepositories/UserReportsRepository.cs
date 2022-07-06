using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class UserReportsRepository : Repository<UserReports> , IUserReportsRepository
    {
        public UserReportsRepository(DataContext context) : base(context)
        {
        }
    }
}
