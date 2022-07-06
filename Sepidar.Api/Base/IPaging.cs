using System.Collections.Generic;

namespace Sepidar.api.Base
{
    public interface IPaging<T>
    {
        IEnumerable<T> Data { get; set; }
        int TotalRecord { get; set; }
    }
}
