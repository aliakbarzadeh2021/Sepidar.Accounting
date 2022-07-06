using System;
using Sepidar.Logger.Extentions;
using Sepidar.Message.Base;

namespace Sepidar.Logger.Models
{
    public class CommandLog
    {
        private CommandLog(ICommandBase command, Exception exception, bool operationSuccess)
        {
            Id = Guid.NewGuid();
            Exception = exception?.ToString();
            StackTrace = exception?.StackTrace;
            OperationSuccess = operationSuccess;
            Date = DateTime.Now;
            SerializedCommand = command.Serialize();
            CommandType = command.GetType().Name;
        }

        public static CommandLog Success(ICommandBase command)
        {
            return new CommandLog(command, null, true);
        }

        public static CommandLog Fail(ICommandBase command, Exception exception)
        {
            return new CommandLog(command, exception, false);
        }

        /// <summary>
        /// شناسه
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// خطا ( در صورت رخ دادن )
        /// </summary>
        public string Exception { get; set; }

        /// <summary>
        /// StackTrace
        /// </summary>
        public string StackTrace { get; set; }

        /// <summary>
        /// تاریخ لاگ
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// آیا عملیات موفق بوده است ?
        /// </summary>
        public bool OperationSuccess { get; set; }

        /// <summary>
        /// دیتای موجود در کامند
        /// </summary>
        public string SerializedCommand { get; set; }

        /// <summary>
        /// نوع کامند
        /// </summary>
        public string CommandType { get; set; }

        // FOR ORM !
        private CommandLog() { }
    }
}