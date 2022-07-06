using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PersonnelInitiateElementRepository : Repository<PersonnelInitiateElement> , IPersonnelInitiateElementRepository
    {
        public PersonnelInitiateElementRepository(DataContext context) : base(context)
        {
        }
    }
}
