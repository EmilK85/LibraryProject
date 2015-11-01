using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories 
{
    public class BookRepository: IRepository<Book,int> 
    {
        LibraryContext _context;

        public BookRepository(LibraryContext ctx) 
        {
            _context = ctx;
        }

        public IEnumerable<Book> All() 
        {
            return _context.Books.ToList();
        }

        public void Add(Book item)
        {
            _context.Books.Add(item);
            _context.SaveChanges();
        }

        public bool TryAdd(string author, string title, string isbn, string description)
        {
            if (author == "")
            {
                return false;
            }

            if (title == "")
            {
                return false;
            }

            if (isbn == "")
            {
                return false;
            }

            if (description == "")
            {
                return false;
            }


            Author _author = new Author();

            var item = _context.Authors.SingleOrDefault(a => a.Name == author);

            if (item is Author)
            {
                _author = (Author)item;
            }
            else
            {
                _author.Name = author;
                _author.books = new List<Book>();
                _context.Authors.Add(_author);
            }

            long Isbn = long.Parse(isbn);
            int nrOfCopies = 0;
            Book book = new Book(_author, title, description, Isbn, nrOfCopies);
            _author.books.Add(book);
            Add(book);

            return true;
        }

        public void AddCopy(Book item)
        {
            int id = item.Id;
            foreach(Book b in _context.Books)
            {
                if(id == b.Id)
                {
                    b.AddCopy();
                }
            }
            _context.SaveChanges();
        }

        public void Remove(Book item)
        {
        }

        public Book Find(int id)
        {
            Book book = _context.Books.SingleOrDefault(b => b.Id == id);
            return book; 
        }

        public void Edit(Book item)
        {
        }
    }
}