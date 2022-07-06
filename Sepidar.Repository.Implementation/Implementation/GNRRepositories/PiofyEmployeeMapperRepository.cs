using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PiofyEmployeeMapperRepository : Repository<PiofyEmployeeMapper> , IPiofyEmployeeMapperRepository
    {
        public PiofyEmployeeMapperRepository(DataContext context) : base(context)
        {
        }
    }
}
