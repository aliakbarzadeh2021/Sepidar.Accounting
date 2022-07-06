using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ImportExportTemplateRepository : Repository<ImportExportTemplate> , IImportExportTemplateRepository
    {
        public ImportExportTemplateRepository(DataContext context) : base(context)
        {
        }
    }
}
