using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models 
{
    public class Book 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Author author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long IsbnNumber { get; set; }
        public int NrOfCopies { get; set; }
        public List<BookCopy> bCopyList { get; set; }
        
        public Book()
        { }

        public Book(Author _author, string title, string description, long isbnNumber, int nrOfCopies)
        {
            this.author = _author;
            this.Title = title;
            this.Description = description;
            this.IsbnNumber = isbnNumber;
            this.NrOfCopies = nrOfCopies;
            CreateBookCopyList(nrOfCopies);

        }

        public override string ToString() 
        {
            return String.Format("[{0}] -- {1} -- {2} -- {3} -- {4} -- {5}",
                this.Id, this.Title, this.IsbnNumber, bCopyList.Count, this.Description, this.author.Name);
        }

        private void CreateBookCopyList(int nrOfCopies)
        {
            bCopyList = new List<BookCopy>();
            for (int i = 0; i < nrOfCopies; i++)
            {
                bCopyList.Add(new BookCopy(this));
            }
        }

        public void AddCopy()
        {
            bCopyList.Add(new BookCopy(this));
        }
    }
}