using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class AssetRepository : Repository<Asset> , IAssetRepository
    {
        public AssetRepository(DataContext context) : base(context)
        {
        }
    }
}
