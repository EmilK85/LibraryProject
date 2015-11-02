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

        public string CreateLoan(string name, string title)
        {
            return _loanRepository.CreateLoan(name, title);
        }

        public string ReturnLoan(Loan loan)
        {
            OnUpdated(this, new EventArgs());
            return _loanRepository.ReturnLoan(loan);
        }

        public List<Loan> LoansByMember(string name)
        {
            return _loanRepository.LoansByMember(name);
        }

        public void OnUpdated(object sender, EventArgs e)
        {
            if (Updated != null)
            {
                Updated(this, e);
            }
        }

        public void ModLoan(Loan item)
        {
            OnUpdated(this, new EventArgs());
            _loanRepository.ModLoan(item);
        }
    }
}
