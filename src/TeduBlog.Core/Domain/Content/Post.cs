using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduBlog.Core.Domain.Content
{
    //cách này gọi là artribute
    [Table("Posts")]//tên bảng
    [Index(nameof(Slug), IsUnique = true)]
    public class Post
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(250)]
        public required string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(250)")]
        public required string Slug { get; set; } // đường link url

        [MaxLength(500)]
        public string? Description { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        [MaxLength(500)]
        public string? Thumbnail { get; set; } // ảnh đại diện
        public string? Content { get; set; }

        [MaxLength(500)]
        public Guid AuthorUserId { get; set; }//Người đăng

        [MaxLength(128)]
        public string? Source { get; set; }//Nguồn (TH nếu chúng ta đi copy ở đâu thì phải ghi nguồn)

        [MaxLength(250)]
        public string? Tags { get; set; }

        [MaxLength(160)]
        public string? SeoDescription { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool IsPaid { get; set; }//đã thanh toán cho user đăng bài chưa
        public double RoyaltyAmount { get; set; }// Tiền bản quyền
        public PostStatus Status { get; set; }
    }
    public enum PostStatus
    {
        Draft = 1,// bản nháp
        Canceled = 2,//Hủy
        WaitingForApproval = 3, // đang chờ phê duyệt
        Rejected = 4,//Loại bỏ
        WaitingForPublish = 5,// đang chờ xuất bản
        Published = 6// đã xuất bản
    }
}
