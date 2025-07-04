
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Core.Domain.Content
{
    [Table("Series")]
    [Index(nameof(Slug), IsUnique = true)]
    public class Series
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(200)]
        [Required]
        public required string Name { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
        [Column(TypeName = "varchar(200)")]
        public required string Slug { get; set; }
        public bool IsActive { get; set; }
        public int SortOrder { get; set; }
        [MaxLength(200)]
        public string? SeoDescription { get; set; }
        [MaxLength(200)]
        public string? Thumbnail { get; set; }
        public string? Content { get; set; }
        public Guid OwnerUserId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
