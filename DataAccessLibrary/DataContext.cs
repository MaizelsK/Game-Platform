using DataAccessLibrary.Entities;
using DataAccessLibrary.Helpers;
using System;
using System.Data.Entity;

namespace DataAccessLibrary
{
    public class DataContext : DbContext
    {
        public DataContext() : base("GamePlatformDb")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<Comment> Commets { get; set; }
    }

    public class DbInitializer : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            PasswordHasher hasher = new PasswordHasher();

            User adminUser = new User()
            {
                Username = "admin",
                Email = "domo.ddr@gmail.com",
                PasswordHash = hasher.Hash("admin"),
                CreateDate = DateTime.Now,
                Status = Enums.Status.offline
            };

            context.Users.Add(adminUser);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
