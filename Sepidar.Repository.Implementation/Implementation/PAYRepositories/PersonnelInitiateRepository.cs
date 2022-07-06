using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PersonnelInitiateRepository : Repository<PersonnelInitiate> , IPersonnelInitiateRepository
    {
        public PersonnelInitiateRepository(DataContext context) : base(context)
        {
        }
    }
}
