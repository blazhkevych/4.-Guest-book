using Microsoft.EntityFrameworkCore;

namespace Guest_book.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
            if (Database.EnsureCreated())
            {
                User admin = new User
                {
                    Name = "admin", 
                    Pwd = "admin"
                };
                User user = new User
                {
                    Name = "user", 
                    Pwd = "user"
                };
                User user1 = new User
                {
                    Name = "user1", 
                    Pwd = "user1"
                };
                Users.AddRange(admin, user, user1);
                SaveChanges();
            }
        }
    }
}
