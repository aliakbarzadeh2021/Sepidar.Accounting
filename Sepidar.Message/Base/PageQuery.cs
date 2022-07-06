
namespace Sepidar.Message.Base
{
    public class PageQuery : IPageQuery
    {
        public PageQuery()
        {
            PageSize = 10;
            PageIndex = 1;
        }

        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public string OrderBy { get; set; }
    }
}
