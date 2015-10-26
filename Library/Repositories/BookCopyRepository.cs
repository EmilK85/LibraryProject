using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext _context;

        public BookCopyRepository(LibraryContext ctx) 
        {
            _context = ctx;
        }

        public void Add(BookCopy item)
        {
            _context.BookCopies.Add(item);
            _context.SaveChanges();
        }

        public void Remove(BookCopy item)
        {
        }

        public BookCopy Find(int id)
        {
            BookCopy bookCopy = new BookCopy();
            foreach (BookCopy bCopy in _context.BookCopies)
            {
                if(bCopy.BookCopyId == id)
                {
                    bookCopy = bCopy;
                }
            }

            return bookCopy;
        }

        public void Edit(BookCopy item)
        {
        }

        public IEnumerable<BookCopy> All()
        {
            return _context.BookCopies.ToList();
        }
    }
}
