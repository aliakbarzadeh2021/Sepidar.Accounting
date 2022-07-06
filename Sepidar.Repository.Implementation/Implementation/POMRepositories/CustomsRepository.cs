using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CustomsRepository : Repository<Customs> , ICustomsRepository
    {
        public CustomsRepository(DataContext context) : base(context)
        {
        }
    }
}
