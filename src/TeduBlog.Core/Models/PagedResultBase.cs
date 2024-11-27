namespace TeduBlog.Core.Models
{
    public abstract class PagedResultBase
    {
        public int CurrentPage { get; set; } // page hiện tại

        public int PageCount // số trang
        {
            get
            {
                var pageCount = (double)RowCount / PageSize;
                return (int)Math.Ceiling(pageCount);
            }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                PageCount = value;
            }
        }

        public int PageSize { get; set; } // độ dài trang
        public int RowCount { get; set; } // tổng số dòng

        public int FirstRowOnPage => (CurrentPage - 1) * PageSize + 1; // check trang đầu

        public int LastRowOnPage => Math.Min(CurrentPage * PageSize, RowCount); // check trang cuối

        public string? AdditionalData { get; set; }
    }
}
