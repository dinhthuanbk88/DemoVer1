﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
   public class DemoAppDbContext : DbContext
    {
        public DbSet<ThietBi> ThietBis { get; set; }
        public DbSet<LoaiThietBi> LoaiThietBis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=TENHANDSOME\SQLEXPRESS;Initial Catalog=DemoApp;Integrated Security=True");
        }
    }
}
