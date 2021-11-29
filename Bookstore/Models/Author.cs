using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First name")]
        [StringLength(30, ErrorMessage = "First name must be below 30 characters.")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        [StringLength(30, ErrorMessage = "Last name must be below 30 characters.")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }

        [Range(1, 100)]
        public int Age { get; set; }

        [StringLength(100, ErrorMessage = "City must be below 100 characters.")]
        public string City { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Country must be below 100 characters.")]
        public string Country { get; set; }

        [Display(Name = "Author")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public virtual ICollection<Book> Books { get; set; }
    }
}