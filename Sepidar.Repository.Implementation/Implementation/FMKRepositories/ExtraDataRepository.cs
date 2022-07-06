using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ExtraDataRepository : Repository<ExtraData> , IExtraDataRepository
    {
        public ExtraDataRepository(DataContext context) : base(context)
        {
        }
    }
}
