using EmbeddedChatbotApp.APIs;
using EmbeddedChatbotApp.Infrastructure;
using EmbeddedChatbotApp.Infrastructure.Models;

namespace EmbeddedChatbotApp.APIs;

public abstract class ChatsServiceBase : IChatsService
{
    protected readonly EmbeddedChatbotAppDbContext _context;

    public ChatsServiceBase(EmbeddedChatbotAppDbContext context)
    {
        _context = context;
    }
}
