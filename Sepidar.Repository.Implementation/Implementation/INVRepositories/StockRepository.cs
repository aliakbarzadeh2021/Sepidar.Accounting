using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class StockRepository : Repository<Stock> , IStockRepository
    {
        public StockRepository(DataContext context) : base(context)
        {
        }
    }
}
