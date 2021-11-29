using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Type must be below 50 characters.")]
        public string Type { get; set; }

        [StringLength(1000, ErrorMessage = "Description must be below 1000 characters.")]
        public string Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}