using TeduBlog.Core.SeedWorks;

namespace TeduBlog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TeduBlogContext _context;
        public UnitOfWork(TeduBlogContext context)
        {
            _context = context;
        }
        public async Task<int> CompleteAsync()
        {
            // Ghi các thay đổi xuống cơ sở dữ liệu
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            // Giải phóng tài nguyên
            _context.Dispose();
        }
    }
}
