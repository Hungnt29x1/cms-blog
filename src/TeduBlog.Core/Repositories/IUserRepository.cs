using TeduBlog.Core.Domain.Identity;
using TeduBlog.Core.SeedWorks;

namespace TeduBlog.Core.Repositories
{
    public interface IUserRepository : IRepository<AppUser, Guid>
    {
        Task RemoveUserFromRoles(Guid userId, string[] roles);
    }
}
