using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class SalvageRepository : Repository<Salvage> , ISalvageRepository
    {
        public SalvageRepository(DataContext context) : base(context)
        {
        }
    }
}
