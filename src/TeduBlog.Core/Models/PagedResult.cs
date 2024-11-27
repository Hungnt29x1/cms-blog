namespace TeduBlog.Core.Models
{
    //Hứng kết quả đã phân trang => và nó sẽ có tập list result
    public class PagedResult<T> : PagedResultBase where T : class
    {
        public List<T> Results { get; set; }

        public PagedResult()
        {
            Results = new List<T>();
        }
    }
}
