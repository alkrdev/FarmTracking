using BackendLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendLibrary {
    public class LibraryContext : DbContext {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server = localhost; Database = farmerdb; Uid = root; Pwd =;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActiveMachine>()
                .HasOne(a => a.field)
                .WithOne(b => b.ActiveMachine);
        }

        public DbSet<Field> Fields { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<ActiveMachine> ActiveMachines { get; set; }

    }
}
