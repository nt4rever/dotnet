using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Model.Models
{
    public class ShopContext : DbContext
    {
        private const string connectionString = @"Server=.; Database=ShopEF; Integrated Security=True;";

        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            optionsBuilder.UseSqlServer(connectionString).UseLoggerFactory(loggerFactory)
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // fluent API
            modelBuilder.Entity<User>(entity =>
            {
                entity
                .ToTable("User")
                .HasComment("This is table user")
                .HasKey(e => e.UserId);

                entity.Property(e => e.UserId).UseIdentityColumn(1,1);
                entity.Property(e => e.UserName)
                .HasColumnName("user_name")
                .HasDefaultValue("null hhh")
                .HasMaxLength(128);
                entity.HasIndex(e => e.UserName).IsUnique();
            });
        }

        public async Task CreateDatabase()
        {
            using var dbContext = new ShopContext();
            string dbName = dbContext.Database.GetDbConnection().Database;
            Console.WriteLine($"=>Creating database: {dbName}");
            bool result = await dbContext.Database.EnsureCreatedAsync();
            string strResult = result ? "=>Database created" : "=>Database existing";
            Console.WriteLine(strResult);
        }

        public async Task DeleteDatabase()
        {
            using var dbContext = new ShopContext();
            string dbName = dbContext.Database.GetDbConnection().Database;
            Console.WriteLine($"=>Deleting database: {dbName}");
            bool result = await dbContext.Database.EnsureDeletedAsync();
            string strResult = result ? "=>Database deleted" : "=>Delete database unsuccessfully";
            Console.WriteLine(strResult);
        }
    }
}
