using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        [Required]
        public int Pnumber { get; set; }

        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.MemberId, this.Pnumber);
        }
    }
}
