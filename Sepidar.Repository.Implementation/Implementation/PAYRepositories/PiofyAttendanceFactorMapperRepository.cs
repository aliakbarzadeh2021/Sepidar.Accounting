using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PiofyAttendanceFactorMapperRepository : Repository<PiofyAttendanceFactorMapper> , IPiofyAttendanceFactorMapperRepository
    {
        public PiofyAttendanceFactorMapperRepository(DataContext context) : base(context)
        {
        }
    }
}
