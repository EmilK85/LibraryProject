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
    class BookService: IService
    {
        BookRepository _bookRepository;

        public BookService(RepositoryFactory repoFactory)
        {
            _bookRepository = repoFactory.GetBookRepository();
        }

        public IEnumerable<Book> All()
        {
            return _bookRepository.All();
        }

        public event EventHandler Updated;

        public void Add(Book item)
        {
            _bookRepository.Add(item);
            OnUpdated(this, new EventArgs());
        }
        
        public void AddCopy(Book item)
        {
            _bookRepository.AddCopy(item);
            OnUpdated(this, new EventArgs());
        }

        public Book Find(int id)
        {
            return _bookRepository.Find(id);
        }

        public bool TryAdd(string author, string title, string isbn, string description)
        {
            if(_bookRepository.TryAdd(author, title, isbn, description))
            {
                OnUpdated(this, new EventArgs());
                return true;
            }
            else
            {
                return false;
            }
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
