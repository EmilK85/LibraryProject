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
        public int TimeOfLoan { get; set; }

        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.LoanId, this.TimeOfLoan);
        }
    }
}
