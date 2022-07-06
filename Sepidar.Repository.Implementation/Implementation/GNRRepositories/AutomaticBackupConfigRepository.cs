using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class AutomaticBackupConfigRepository : Repository<AutomaticBackupConfig> , IAutomaticBackupConfigRepository
    {
        public AutomaticBackupConfigRepository(DataContext context) : base(context)
        {
        }
    }
}
