using EmbeddedChatbotApp.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace EmbeddedChatbotApp.APIs;

public class ChatsService : ChatsServiceBase
{
    public ChatsService(EmbeddedChatbotAppDbContext context)
        : base(context) { }
}
