﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolAPI.Models
{
    public class SchoolContext : System.Data.Entity.DbContext
    {
        public SchoolContext() : base("DefaultConnection") { }
        public DbSet<Student> Students { get; set; }
    }
}