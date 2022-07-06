using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CheckDataParityItemRepository : Repository<CheckDataParityItem> , ICheckDataParityItemRepository
    {
        public CheckDataParityItemRepository(DataContext context) : base(context)
        {
        }
    }
}
