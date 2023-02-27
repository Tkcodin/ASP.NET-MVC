﻿using Microsoft.EntityFrameworkCore;
using MyAPItest.Models;

namespace MyAPItest.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
