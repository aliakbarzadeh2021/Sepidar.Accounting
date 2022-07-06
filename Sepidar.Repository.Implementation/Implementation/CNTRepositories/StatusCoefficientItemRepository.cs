using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class StatusCoefficientItemRepository : Repository<StatusCoefficientItem> , IStatusCoefficientItemRepository
    {
        public StatusCoefficientItemRepository(DataContext context) : base(context)
        {
        }
    }
}
