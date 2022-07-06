using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class BackupRepository : Repository<Backup> , IBackupRepository
    {
        public BackupRepository(DataContext context) : base(context)
        {
        }
    }
}
