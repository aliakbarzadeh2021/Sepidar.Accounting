using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PhoneLineRepository : Repository<PhoneLine> , IPhoneLineRepository
    {
        public PhoneLineRepository(DataContext context) : base(context)
        {
        }
    }
}
