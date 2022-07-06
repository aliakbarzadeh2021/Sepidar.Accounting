using Sepidar.Infrastructure.Enum;

namespace Sepidar.Infrastructure.Base
{
    /// <summary>
    /// کلاس در برگیرنده پیام بازگشتی تابع
    /// </summary>
    public class ResponseModel
    {
        /// <summary>
        /// نوع پیام
        /// </summary>
        public ResultType Type { get; protected set; }

        /// <summary>
        /// متن پیام
        /// </summary>
        public object Message { get; protected set; }

        protected ResponseModel(ResultType type, object message)
        {
            Type = type;
            Message = message;
        }


        protected ResponseModel()
        {

        }


        public static ResponseModel Success(params object[] formatters)
        {
            return new ResponseModel(ResultType.Success, formatters);
        }

        public static ResponseModel Error(string message)
        {
            return new ResponseModel(ResultType.Error, message);
        }

        public static ResponseModel Success(string message)
        {
            return new ResponseModel(ResultType.Success, message);
        }

        public static ResponseModel Success()
        {
            return new ResponseModel(ResultType.Success, string.Empty);
        }

    }
}
