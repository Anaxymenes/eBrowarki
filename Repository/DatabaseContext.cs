using Data.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class DatabaseContext : DbContext {

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options) { }

        public DbSet<Role> Role { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<AccountToken> AccountToken { get; set; }
        public DbSet<AccountVerification> AccountVerification { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<BeerType> BeerType { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Brewery> Brewery { get; set; }
        public DbSet<Beer> Beer { get; set; }
        public DbSet<BeerTypeBeer> BeerTypeBeer { get; set; }
        public DbSet<Vote> Vote { get; set; }
        public DbSet<Comment> Comment { get; set; }
        


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Role>()
                .HasMany(x => x.Accounts)
                .WithOne(c => c.Role)
                .HasForeignKey(b => b.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Role>()
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Account>()
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Account>()
                .HasMany(x => x.Products)
                .WithOne(c => c.Account)
                .HasForeignKey(b => b.AccountId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Account>()
                .HasMany(x => x.Comments)
                .WithOne(c => c.Account)
                .HasForeignKey(b => b.AccountId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Account>()
                .HasMany(x => x.Votes)
                .WithOne(c => c.Account)
                .HasForeignKey(b => b.AccountId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Account>()
                .HasOne(x => x.AccountToken)
                .WithOne(c => c.Account)
                .HasForeignKey<AccountToken>(b => b.AccountId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Account>()
                .HasOne(x => x.AccountVerification)
                .WithOne(c => c.Account)
                .HasForeignKey<AccountVerification>(b => b.AccountId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Country>()
                .HasMany(x => x.Products)
                .WithOne(c => c.Country)
                .HasForeignKey(b => b.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Country>()
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<AccountToken>()
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<AccountVerification>()
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>()
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>()
                .HasOne(x => x.Beer)
                .WithOne(c => c.Product)
                .HasForeignKey<Beer>(c => c.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
                .HasOne(x => x.Brewery)
                .WithOne(c => c.Product)
                .HasForeignKey<Brewery>(b => b.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
                .HasMany(x => x.Comments)
                .WithOne(c => c.Product)
                .HasForeignKey(b => b.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasMany(x => x.Votes)
                .WithOne(c => c.Product)
                .HasForeignKey(b => b.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BeerType>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<BeerType>()
                .HasMany(x => x.BeerTypeBeers)
                .WithOne(c => c.BeerType)
                .HasForeignKey(b => b.BeerTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Beer>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>()
                .HasMany(x => x.BeerTypeBeers)
                .WithOne(c => c.Product)
                .HasForeignKey(f => f.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Brewery>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Brewery>()
                .HasMany(x => x.Beers)
                .WithOne(c => c.Brewery)
                .HasForeignKey(b => b.BreweryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Comment>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Vote>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
