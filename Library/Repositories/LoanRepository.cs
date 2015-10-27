using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class LoanRepository: IRepository<Loan, int>
    {
        LibraryContext _context;

        public LoanRepository(LibraryContext ctx) 
        {
            _context = ctx;
        }

        public void Add(Loan item)
        {
            _context.Loans.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Loan item)
        {
            _context.Loans.Remove(item);
            _context.SaveChanges();
        }

        public Loan Find(int id)
        {
            Loan loan = new Loan();
            foreach (Loan l in _context.Loans)
            {
                if (l.LoanId == id)
                {
                    loan = l;
                }
            }
            return loan; 
        }

        public void Edit(Loan item)
        {
        }

        public IEnumerable<Loan> All()
        {
            return _context.Loans.ToList();
        }

        public int ReturnLoan(Loan loan)
        {
            loan.TimeOfReturn = DateTime.Now;

            if (DateTime.Now < loan.DueDate)
            {
                return 0;
            }
            else
            {
                double differance = (DateTime.Now.Date - loan.DueDate.Date).TotalDays;
                int diff = Convert.ToInt32(differance);
                return diff;
            }
        }
    }
}
