using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library.Services
{
    class LoanService: IService
    {
        public event EventHandler Updated;

        LoanRepository _loanRepository;

        public LoanService(RepositoryFactory repoFactory)
        {
            _loanRepository = repoFactory.GetLoanRepository();
        }

        public IEnumerable<Loan> All()
        {
            return _loanRepository.All();
        }

        public void Add(Loan item)
        {
            _loanRepository.Add(item);
        }

        public void Remove(Loan item)
        {
            _loanRepository.Remove(item);
        }

        public Loan Find(int id)
        {
            return _loanRepository.Find(id);
        }

        public int ReturnLoan(Loan loan)
        {
            return _loanRepository.ReturnLoan(loan);
        }
    }
}
