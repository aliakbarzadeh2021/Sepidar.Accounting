using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class DeviceUserPartyRepository : Repository<DeviceUserParty> , IDeviceUserPartyRepository
    {
        public DeviceUserPartyRepository(DataContext context) : base(context)
        {
        }
    }
}
