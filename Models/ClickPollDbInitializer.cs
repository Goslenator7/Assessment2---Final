using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Assessment2___Final.Data;

namespace Assessment2___Final.Models
{
    public class ClickPollDbInitializer : DropCreateDatabaseIfModelChanges<ClickPollDB>
    {
        protected override void Seed(ClickPollDB context)
        {
            Cause Cause1 = new Cause()
            {
                Title = "Stop politics!",
                Description = "Stop politics! It's too political!",
                Signed = 0

            };
            context.Causes.Add(Cause1);
            base.Seed(context);
        }
    }
}