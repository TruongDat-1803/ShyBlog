
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Core.Domain.Content
{
    [Table("PostCategories")]
    [Index(nameof(Slug), IsUnique = true)]
    public class PostCategory
    {
        [Key] public Guid Id { get; set; }
        [MaxLength(200)]
        public required string Name { get; set; }
        [Column(TypeName = "varchar(200)")]
        public required string Slug { get; set; }
        [Required]
        public Guid? ParentId { get; set; }
        [MaxLength(500)]
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        [MaxLength(160)]
        public string? SeoDescription { get; set; }
        public int SortOrder { get; set; }
    }
}
