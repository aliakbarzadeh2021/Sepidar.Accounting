using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class FormulaBomItemAlternativeRepository : Repository<FormulaBomItemAlternative> , IFormulaBomItemAlternativeRepository
    {
        public FormulaBomItemAlternativeRepository(DataContext context) : base(context)
        {
        }
    }
}
