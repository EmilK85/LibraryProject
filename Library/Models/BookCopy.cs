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

        public BookCopy() { }

        public BookCopy(Book _book)
        {
            this.book = _book;
        }

        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.BookCopyId, this.book.Title);
        }
    }
}
