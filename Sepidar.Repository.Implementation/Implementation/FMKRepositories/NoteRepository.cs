using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class NoteRepository : Repository<Note> , INoteRepository
    {
        public NoteRepository(DataContext context) : base(context)
        {
        }
    }
}
