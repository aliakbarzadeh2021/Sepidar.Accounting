using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PiofyAttendanceFactorRepository : Repository<PiofyAttendanceFactor> , IPiofyAttendanceFactorRepository
    {
        public PiofyAttendanceFactorRepository(DataContext context) : base(context)
        {
        }
    }
}
