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
            Book book = new Book();
            foreach (Book b in _context.Books)
            {
                if (b.Id== id)
                {
                    book = b;
                }
            }
            return book;
        }

        public void Edit(Book item)
        {
        }
    }
}