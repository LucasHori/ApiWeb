using Microsoft.EntityFrameworkCore;
using ProjetoF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=123456;Persist Security Info=True;User ID=sa;Initial Catalog=DbAppWeb;Data Source=DESKTOP-Q2GNR7H\\SQLEXPRESS");
        }

    }
}
