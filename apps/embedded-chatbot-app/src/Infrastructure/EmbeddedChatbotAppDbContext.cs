using Microsoft.EntityFrameworkCore;

namespace EmbeddedChatbotApp.Infrastructure;

public class EmbeddedChatbotAppDbContext : DbContext
{
    public EmbeddedChatbotAppDbContext(DbContextOptions<EmbeddedChatbotAppDbContext> options)
        : base(options) { }
}
