﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using DataAccessLevel.Entities;

namespace DataAccessLevel.EntityFramework
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(string conectionString) : base(conectionString) { }

        public DbSet<Request> Requests { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
