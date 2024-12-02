using EmbeddedChatbotApp.APIs;
using Microsoft.AspNetCore.Mvc;

namespace EmbeddedChatbotApp.APIs;

[ApiController()]
public class ChatsController : ChatsControllerBase
{
    public ChatsController(IChatsService service)
        : base(service) { }
}
