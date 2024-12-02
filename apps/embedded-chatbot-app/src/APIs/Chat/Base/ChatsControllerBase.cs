using EmbeddedChatbotApp.APIs;
using Microsoft.AspNetCore.Mvc;

namespace EmbeddedChatbotApp.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ChatsControllerBase : ControllerBase
{
    protected readonly IChatsService _service;

    public ChatsControllerBase(IChatsService service)
    {
        _service = service;
    }
}
