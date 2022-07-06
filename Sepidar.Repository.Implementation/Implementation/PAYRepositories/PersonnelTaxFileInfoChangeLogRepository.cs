using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PersonnelTaxFileInfoChangeLogRepository : Repository<PersonnelTaxFileInfoChangeLog> , IPersonnelTaxFileInfoChangeLogRepository
    {
        public PersonnelTaxFileInfoChangeLogRepository(DataContext context) : base(context)
        {
        }
    }
}
