using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment2___Final.Models
{
    public class Signature
    {
        public int SignatureID { get; set; }

        public int CauseID { get; set; }

        public int UserID { get; set; }

        public string Username { get; set; }


        public virtual Cause Cause { get; set; }

        public virtual User User { get; set; }
    }
}