using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Text;

namespace Library.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Book> books { get; set; }

        public Author(){ }

        public Author(string name, List<Book> bookList)
        {
            this.Name = name;
            this.books = bookList;
        }

        public override string ToString()
        {
            return String.Format("[{0}] -- {1}{2}", this.AuthorId, this.Name, ListInfo());
        }

        private string ListInfo()
        {
            StringBuilder builder = new StringBuilder();
            foreach (Book b in books)
            {
                builder.Append(" -- ").Append(b.Title);
            }
            string result = builder.ToString();
            return result;
        }
    }
}
