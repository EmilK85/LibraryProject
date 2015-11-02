//Emil Kronström & Love Hermansson
//OOP2
//02/11 -15
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Text;

namespace Library.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        [Required]
        public int Pnumber { get; set; }
        public string Name { get; set; }
        public List<Loan> loans { get; set; }

        public Member() { }

        public Member(int pNumber, string name)
        {
            loans = new List<Loan>();
            this.Pnumber = pNumber;
            this.Name = name;
        }

        public Member(int pNumber, string name, List<Loan> loanList)
        {
            this.Pnumber = pNumber;
            this.Name = name;
            this.loans = loanList;
        }

        public override string ToString()
        {
            return String.Format("[{0}] -- {1} -- {2}{3}", 
                this.MemberId, this.Pnumber, this.Name, ListInfo());
        }

        private string ListInfo()
        {
            StringBuilder builder = new StringBuilder();
            foreach (Loan l in loans)
            {
                builder.Append(" -- ").Append(l.LoanId.ToString());
            }
            string result = builder.ToString();
            return result;
        }
    }
}
