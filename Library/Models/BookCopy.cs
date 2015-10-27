using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class BookCopy
    {
        [Key]
        public int BookCopyId { get; set; }
        [Required]
        public Book book { get; set; }
        public bool IsLoaned { get; set; }

        public BookCopy() 
        {
            this.book = new Book();
            this.IsLoaned = false;
        }

        public BookCopy(Book _book)
        {
            this.book = _book;
            this.IsLoaned = false;
        }

        public override string ToString()
        {
            string availability = "Available";
            if(this.IsLoaned)
            {
                availability = "Loaned";
            }
            return String.Format("[{0}] -- {1} -- {2}", this.BookCopyId, this.book.Title, availability);
        }
    }
}
