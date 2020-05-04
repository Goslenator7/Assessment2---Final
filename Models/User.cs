using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment2___Final.Models
{
    public class User
    {
        public virtual int UserID { get; set; }
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }

        public virtual string Password { get; set; }

        public virtual string ConfirmPassword { get; set; }

        public virtual List<Cause> Cause { get; set; }
        public virtual List<Signature> Signatures { get; set; }
    }
}