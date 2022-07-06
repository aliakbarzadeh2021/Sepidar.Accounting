using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class AssetClassRepository : Repository<AssetClass> , IAssetClassRepository
    {
        public AssetClassRepository(DataContext context) : base(context)
        {
        }
    }
}
