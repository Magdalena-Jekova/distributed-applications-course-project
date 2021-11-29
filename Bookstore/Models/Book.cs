using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Title must be below 100 characters.")]
        public string Title { get; set; }

        [Display(Name = "Total pages ")]
        [Range(1, 1500)]
        public int TotalPages { get; set; }

        [Display(Name = "Published on ")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [Display(Name = "Author")]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        public double Price { get; set; }

        public bool IsAvailable { get; set; }
    }
}