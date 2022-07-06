using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class EmplacementRepository : Repository<Emplacement> , IEmplacementRepository
    {
        public EmplacementRepository(DataContext context) : base(context)
        {
        }
    }
}
