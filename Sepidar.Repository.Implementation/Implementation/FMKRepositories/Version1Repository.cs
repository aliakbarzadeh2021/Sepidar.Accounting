using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class Version1Repository : Repository<Version1> , IVersion1Repository
    {
        public Version1Repository(DataContext context) : base(context)
        {
        }
    }
}
