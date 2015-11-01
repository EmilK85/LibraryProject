using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class BookCopyService: IService
    {
        BookCopyRepository _bookCopyRepository;
        public event EventHandler Updated;

        public BookCopyService(RepositoryFactory repoFactory)
        {
            _bookCopyRepository = repoFactory.GetBookCopyRepository();
        }

        public IEnumerable<BookCopy> All()
        {
            return _bookCopyRepository.All();
        }

        public void Add(BookCopy item)
        {
            _bookCopyRepository.Add(item);
        }

        public BookCopy Find(int id)
        {
            return _bookCopyRepository.Find(id);
        }

        public void OnUpdated(object sender, EventArgs e)
        {
            if (Updated != null)
            {
                Updated(this, e);
            }
        }

        public List<BookCopy> AvailableBooks()
        {
            return _bookCopyRepository.AvailableBooks();
        }
    }
}
