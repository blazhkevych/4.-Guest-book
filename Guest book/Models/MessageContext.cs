

using Microsoft.EntityFrameworkCore;

namespace Guest_book.Models
{
    public class MessageContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }

        public MessageContext(DbContextOptions<MessageContext> options)
            : base(options)
        {
            if (Database.EnsureCreated())
            {
                Messages.Add(new Message
                {
                    MessageText = "Hello",
                    MessageDate = System.DateTime.Now
                });

                Messages.Add(new Message
                {
                    MessageText = "World",
                    MessageDate = System.DateTime.Now
                });

                Messages.Add(new Message
                {
                    MessageText = "!",
                    MessageDate = System.DateTime.Now
                });

                mes


                SaveChanges();
            }
        }
    }
}
