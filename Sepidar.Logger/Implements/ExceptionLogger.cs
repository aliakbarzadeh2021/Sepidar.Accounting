using System.Threading.Tasks;
using Sepidar.Logger.Context;
using Sepidar.Logger.Interfaces;
using Sepidar.Logger.Models;

namespace Sepidar.Logger.Implements
{
    public class ExceptionLogger : IExceptionLogger
    {
        private readonly LogContext _context;

        public ExceptionLogger(LogContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task LogAsync(ExceptionLog log)
        {
            _context.ExceptionLogs.Add(log);
            await _context.SaveChangesAsync();
        }
    }
}
