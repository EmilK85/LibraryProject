using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class MemberRepository : IRepository<Member, int>
    {
        LibraryContext _context;

        public MemberRepository(LibraryContext ctx) 
        {
            _context = ctx;
        }

        public void Add(Member item)
        {
            _context.Members.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Member item)
        {
        }

        public Member Find(int id)
        {
            Member member = _context.Members.SingleOrDefault(m => m.MemberId == id);
            return member; 
        }

        public void Edit(Member item)
        {
        }

        public IEnumerable<Member> All()
        {
            return _context.Members.ToList();
        }

        public List<Loan> LoansByMember(string name)
        {
            List<Loan> loanList = new List<Loan>();
            loanList = _context.Loans.Where(item => item.member.Name == name).ToList();
            return loanList;
        }

        public void RemoveLoan(Loan item, string name)
        {
            List<Loan> loanList = LoansByMember(name);
            loanList.Remove(item);
        }
    }
}
