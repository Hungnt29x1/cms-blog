using AutoMapper;
using TeduBlog.Core.Repositories;
using TeduBlog.Core.SeedWorks;
using TeduBlog.Data.Repositories;

namespace TeduBlog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TeduBlogContext _context;
        public UnitOfWork(TeduBlogContext context, IMapper mapper)
        {
            _context = context;
            Posts = new PostRepository(context, mapper);
        }

        public IPostRepository Posts { get; private set; }

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
