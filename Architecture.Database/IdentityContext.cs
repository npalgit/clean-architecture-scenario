﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Architecture.Database.Entities;
using Architecture.Database.Common;

namespace Architecture.Database
{
    public class IdentityContext : IdentityDbContext<User, IdentityRole<int>, int>, IDbContext
    {
        public DbSet<User> User { get; set; }

        public IdentityContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-Architecture-77e12622-3a30-4603-a018-866ba0ccb822;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
