﻿
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Core.Domain.Content
{
    [Table("Posts")]
    [Index(nameof(Slug), IsUnique = true)]
    public class Post
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(200)]
        public required string Name { get; set; }
        [Required]
        [Column(TypeName = "varchar(200)")]
        public required string Slug { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        [MaxLength(500)]
        public string? Thumbnail { get; set; }
        [MaxLength(128)]
        public string? Source { get; set; }
        [MaxLength(128)]
        public Guid AuthorId { get; set; }
        [MaxLength(250)]
        public string? Tags { get; set; }
        [MaxLength(160)]
        public string? SeoDescription { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool IsPaid { get; set; }
        public double RoyaltyAmount { get; set; }
        public PostStatus Status { get; set; } = PostStatus.Draft;
    }
}

public enum PostStatus
{
    Draft = 1,
    Cancelled = 2,
    WaitingForApproval = 3,
    Rejected = 4,
    WaitingForPublish = 5,
    Published = 6,
}
