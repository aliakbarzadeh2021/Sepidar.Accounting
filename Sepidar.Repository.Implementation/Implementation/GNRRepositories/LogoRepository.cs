using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class LogoRepository : Repository<Logo> , ILogoRepository
    {
        public LogoRepository(DataContext context) : base(context)
        {
        }
    }
}
