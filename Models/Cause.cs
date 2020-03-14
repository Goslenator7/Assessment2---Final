using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment2___Final.Models
{
    public class Cause
    {
        public int CauseID { get; set; }
        public string CauseTitle { get; set; }
        public string CauseDescription { get; set; }
        public byte [] CauseImage { get; set; }

        public int UserID { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Signature> Signature { get; set; }
    }
}