using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class DLRepository : Repository<DL> , IDLRepository
    {
        public DLRepository(DataContext context) : base(context)
        {
        }
    }
}
