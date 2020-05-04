using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment2___Final.Models
{
    public class Cause
    {
        public virtual int CauseID { get; set; }
        public virtual string Title { get; set; }
        public virtual string Category { get; set; }
        public virtual string Description { get; set; }
        public virtual byte [] Image { get; set; }

        public virtual int UserID { get; set; }

        public virtual User User { get; set; }
        public virtual List<Signature> Signature { get; set; }
    }
}