using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class AssetGroupRepository : Repository<AssetGroup> , IAssetGroupRepository
    {
        public AssetGroupRepository(DataContext context) : base(context)
        {
        }
    }
}
