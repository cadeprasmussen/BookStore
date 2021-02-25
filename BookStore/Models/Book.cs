using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        //Creating the model > going model first then to database.
        //BookId is the primary key, [Key] is not needed as it is created 
        [Key]
        public int BookId { get; set; }

        [Required]
        public string BookTitle { get; set; }

        [Required]
        public string AuthorFirstName { get; set; }

        [Required]
        public string AuthorMiddleName { get; set; } = "";

        [Required]
        public string AuthorLastName { get; set; }
        [Required]
        public string BookPublisher { get; set; }

        //Adding regular expression requirement
        [Required, RegularExpression(@"^[0-9]{3}(-[0-9]{10})$", ErrorMessage = "Enter ISBN in fromat XXX-XYXYXYXYXY")]
        public string ISBN { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        //Adding numpages to start keeping track of the number of pages in the books
        public int NumPages { get; set; }

        [Required]
        public float Price { get; set; }


    }
}
