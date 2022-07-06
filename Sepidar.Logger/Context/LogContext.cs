using Microsoft.EntityFrameworkCore;
using Sepidar.Logger.Models;

namespace Sepidar.Logger.Context
{
    public class LogContext : DbContext
    {
        public DbSet<CommandLog> CommandLogs { get; set; }

        public DbSet<ExceptionLog> ExceptionLogs { get; set; }
        public LogContext(DbContextOptions<LogContext> options)
            : base(options)
        {
        }
    }
}
