using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PersonnelRepository : Repository<Personnel> , IPersonnelRepository
    {
        public PersonnelRepository(DataContext context) : base(context)
        {
        }
    }
}
