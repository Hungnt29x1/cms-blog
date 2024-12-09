using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeduBlog.Core.Domain.Content
{
    [Table("PostActivityLogs")]
    public class PostActivityLog //Đăng Nhật Ký Hoạt Động
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PostId { get; set; }

        public PostStatus FromStatus { set; get; } // post từ status nào

        public PostStatus ToStatus { set; get; } // post đến status nào

        public DateTime DateCreated { get; set; }

        [MaxLength(500)]
        public string? Note { set; get; }

        public Guid UserId { get; set; }

        [MaxLength(250)]
        public string UserName { get; set; }
    }
}
