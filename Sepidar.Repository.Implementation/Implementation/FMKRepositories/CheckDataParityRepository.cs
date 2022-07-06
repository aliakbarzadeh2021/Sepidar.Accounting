using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CheckDataParityRepository : Repository<CheckDataParity> , ICheckDataParityRepository
    {
        public CheckDataParityRepository(DataContext context) : base(context)
        {
        }
    }
}
