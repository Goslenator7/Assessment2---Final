using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assessment2___Final.Models
{
    public class Cause
    {
        public virtual int CauseID { get; set; }
        public virtual string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public virtual string Description { get; set; }

        public virtual Nullable <int> Signed { get; set; }


    }
}