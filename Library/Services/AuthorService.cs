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
        }

        public List<Book> booksByAuthor(string name)
        {
            return _authorRepository.booksByAuthor(name);
        }

        public Author Find(int id)
        {
            return _authorRepository.Find(id);
        }
    }
}
