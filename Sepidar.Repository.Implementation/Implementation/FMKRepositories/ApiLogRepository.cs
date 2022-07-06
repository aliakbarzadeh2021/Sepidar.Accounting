using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ApiLogRepository : Repository<ApiLog> , IApiLogRepository
    {
        public ApiLogRepository(DataContext context) : base(context)
        {
        }
    }
}
