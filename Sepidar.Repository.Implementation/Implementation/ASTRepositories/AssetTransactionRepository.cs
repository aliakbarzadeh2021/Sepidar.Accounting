using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class AssetTransactionRepository : Repository<AssetTransaction> , IAssetTransactionRepository
    {
        public AssetTransactionRepository(DataContext context) : base(context)
        {
        }
    }
}
