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

        public AuthorRepository (LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(Author item)
        {
            _context.Authors.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Author item)
        {
        }

        public Author Find(int id)
        {
            Author author = _context.Authors.SingleOrDefault(a => a.AuthorId == id);
            return author;      
        }

        public void Edit(Author item)
        {
        }

        public IEnumerable<Author> All()
        {
            return _context.Authors.ToList();
        }

        public List<Book> BooksByAuthor(string name)
        {
            List<Book> bList = new List<Book>();
            bList = _context.Books.Where(a => a.author.Name == name).ToList();
            return bList;
        }
    }
}
