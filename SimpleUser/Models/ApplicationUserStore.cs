using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleUser.Models
{
    public class ApplicationUserStore : UserStore<ApplicationUser>
    {
        public ApplicationUserStore() : this(new ApplicationDbContext())
        { }

        // Replacing the base constructor which accepts a context object
        public ApplicationUserStore(ApplicationDbContext context) : base(context)
        { }

    }
}