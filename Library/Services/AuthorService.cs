//Emil Kronström & Love Hermansson
//OOP2
//02/11 -15
using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class AuthorService: IService
    {
        AuthorRepository _authorRepository;

        public AuthorService(RepositoryFactory repoFactory)
        {
            _authorRepository = repoFactory.GetAuthorRepository();
        }

        public IEnumerable<Author> All()
        {
            return _authorRepository.All();
        }

        public event EventHandler Updated;

        public void Add(Author author)
        {
            _authorRepository.Add(author);
            OnUpdated(this, new EventArgs());
        }

        public List<Book> BooksByAuthor(string name)
        {
            return _authorRepository.BooksByAuthor(name);
        }

        public Author Find(int id)
        {
            return _authorRepository.Find(id);
        }

        public void OnUpdated(object sender, EventArgs e)
        {
            if (Updated != null)
            {
                Updated(this, e);
            }
        }
    }
}
