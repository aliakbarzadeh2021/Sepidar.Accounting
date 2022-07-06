using System.Threading.Tasks;
using Sepidar.Logger.Models;

namespace Sepidar.Logger.Interfaces
{
    public interface IExceptionLogger
    {
        Task LogAsync(ExceptionLog log);
    }
}
