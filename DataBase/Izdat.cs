using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataBase
{
    public partial class Izdat : DbContext
    {
        public Izdat()
            : base("name=Izdat")
        {
        }

        public virtual DbSet<books> books { get; set; }
        public virtual DbSet<contracts> contracts { get; set; }
        public virtual DbSet<customers> customers { get; set; }
        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<writers> writers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<books>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.books)
                .HasForeignKey(e => e.cipher_of_book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<books>()
                .HasMany(e => e.writers)
                .WithMany(e => e.books)
                .Map(m => m.ToTable("books_by_writers").MapLeftKey("cipher_of_book").MapRightKey("passport_number_writer"));

            modelBuilder.Entity<contracts>()
                .HasMany(e => e.writers)
                .WithRequired(e => e.contracts)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customers>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.customers)
                .WillCascadeOnDelete(false);
        }
    }
}
