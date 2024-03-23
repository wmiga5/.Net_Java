using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Weather_api
{
    internal class Currency_Exchange : DbContext
    {
        public DbSet<Currency> Currencies { get; set; }
        public Currency_Exchange()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Exch.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(new Currency() { Id=1,Tag="TEST",Exchange=4.5f});
                }
    }
}
