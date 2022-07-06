using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class FormulaBomItemRepository : Repository<FormulaBomItem> , IFormulaBomItemRepository
    {
        public FormulaBomItemRepository(DataContext context) : base(context)
        {
        }
    }
}
