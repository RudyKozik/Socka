﻿using Microsoft.EntityFrameworkCore;
using SockaBackend.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SockaBackend.Infrastructure
{
    public class Database : DbContext
    {
        public DbSet<User> Users { get; set; }

        public Database()
        {
         
           
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
    }
}
