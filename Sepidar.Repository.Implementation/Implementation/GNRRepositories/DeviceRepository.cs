using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class DeviceRepository : Repository<Device> , IDeviceRepository
    {
        public DeviceRepository(DataContext context) : base(context)
        {
        }
    }
}
