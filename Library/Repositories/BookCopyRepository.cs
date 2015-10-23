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
            throw new NotImplementedException();
        }

        public void Remove(BookCopy item)
        {
            throw new NotImplementedException();
        }

        public BookCopy Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(BookCopy item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookCopy> All()
        {
            return _context.BookCopies.ToList();
        }
    }
}
