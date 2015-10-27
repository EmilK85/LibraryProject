using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }
        [Required]
        public DateTime TimeOfLoan { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? TimeOfReturn { get; set; }
        public BookCopy bookCopy { get; set; }
        public Member member { get; set; }

        public Loan() 
        {
            this.TimeOfLoan = DateTime.Now;
            this.DueDate = DateTime.Now.AddDays(15);
            bookCopy.IsLoaned = true;
            this.bookCopy = new BookCopy();
            this.member = new Member();
        }

        public Loan(BookCopy _bookCopy, Member _member)
        {
            this.member = _member;
            this.bookCopy = _bookCopy;
            this.TimeOfLoan =  DateTime.Now;
            this.DueDate = DateTime.Now.AddDays(15);
            bookCopy.IsLoaned = true;
        }

        public override string ToString()
        {
            return String.Format("[{0}] -- {1} -- {2} -- {3} -- {4}",
                this.LoanId, this.TimeOfLoan, this.DueDate, this.bookCopy.BookCopyId, this.member.Name);
        }
    }
}
