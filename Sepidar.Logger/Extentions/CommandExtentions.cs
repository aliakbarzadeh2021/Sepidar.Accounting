using Newtonsoft.Json;
using Sepidar.Message.Base;

namespace Sepidar.Logger.Extentions
{
    public static class CommandExtentions
    {
        public static string Serialize(this ICommandBase command)
        {
            return JsonConvert.SerializeObject(command);
        }
    }
}