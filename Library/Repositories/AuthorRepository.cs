using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class AuthorRepository : IRepository<Author, int>
    {
        LibraryContext _context;
        string love;

        public AuthorRepository (LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(Author item)
        {
            throw new NotImplementedException();
        }

        public void Remove(Author item)
        {
            throw new NotImplementedException();
        }

        public Author Find(int id)
        {
            throw new NotImplementedException();        
        }

        public void Edit(Author item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> All()
        {
            return _context.Authors.ToList();
        }
    }
}
