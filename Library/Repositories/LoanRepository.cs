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
            Loan loan = _context.Loans.SingleOrDefault(l => l.LoanId == id);
            return loan; 
        }

        public void Edit(Loan item)
        {
        }

        public IEnumerable<Loan> All()
        {
            return _context.Loans.ToList();
        }

        public string ReturnLoan(Loan loan)
        {
            loan.TimeOfReturn = DateTime.Now;
            Remove(loan);

            if (DateTime.Now <= loan.DueDate)
            {
                return "Loan returned";
            }
            else
            {
                double differance = (DateTime.Now.Date - loan.DueDate.Date).TotalDays;
                int diff = Convert.ToInt32(differance);
                diff = diff * 10;

                return "You owe " + diff.ToString() + " kr!";
            }
        }

        public List<Loan> LoansByMember(string name)
        {
            List<Loan> loanList = new List<Loan>();
            loanList = _context.Loans.Where(item => item.member.Name == name).ToList();
            return loanList;
        }

        public string CreateLoan(string name, string title)
        {
            BookCopy bCopy = new BookCopy();
            Member member = new Member();

            foreach(BookCopy b in _context.BookCopies)
            {
                if(b.book.Title == title)
                {
                    if(!b.IsLoaned)
                    {
                        bCopy = b;
                    }
                }
            }

            foreach (Member m in _context.Members)
            {
                if (m.Name == name)
                {
                    member = m;
                }
            }

            if(member.Name != name)
            {
                return "No such member exist";
            }

            if(bCopy.book.Title != title)
            {
                return "Book not available";
            }

            Add(new Loan(bCopy, member));
            return "Success";
        }

        public void ModLoan(Loan item)
        {
            DateTime newTimeOfLoan = DateTime.Now.AddDays(-30);
            DateTime newDueDate = DateTime.Now.AddDays(-15);

            item.TimeOfLoan = newTimeOfLoan;
            item.DueDate = newDueDate;
            _context.SaveChanges();
        }
    }
}
