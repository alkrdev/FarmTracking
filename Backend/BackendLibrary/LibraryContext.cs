using System;
using BackendLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendLibrary {
    public class LibraryContext : DbContext {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server = localhost; Database = farmerdb; Uid = root; Pwd = Jagex2233;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActiveMachine>()
                .HasOne(a => a.Field)
                .WithOne(b => b.ActiveMachine);
        }

        public DbSet<Field> Fields { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<ActiveMachine> ActiveMachines { get; set; }

    }
}
