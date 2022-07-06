using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ExtraColumnDescriptionRepository : Repository<ExtraColumnDescription> , IExtraColumnDescriptionRepository
    {
        public ExtraColumnDescriptionRepository(DataContext context) : base(context)
        {
        }
    }
}
