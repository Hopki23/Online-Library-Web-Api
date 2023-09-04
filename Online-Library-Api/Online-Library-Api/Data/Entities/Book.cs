﻿namespace Online_Library_Api.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Book
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Title { get; set; } = null!;
        public DateTime DateOfPublish { get; set; }

        [Required]
        public string Resume { get; set; } = null!;

        [Required]
        public string GenreName { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public int Likes { get; set; }

        [ForeignKey(nameof(Author))]
        public Guid AuthorId { get; set; }
        public Author Author { get; set; } = null!;
    }
}
