using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muresan_Edmond_Ferenc_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public Author? Author { get; set; }
        public int? AuthorID { get; set; }

        // Include the Borrowing navigation property
        public Borrowing? Borrowing { get; set; }
        public int? BorrowingID { get; set; }

        public Publisher? Publisher { get; set; }
        public int? PublisherID { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}

