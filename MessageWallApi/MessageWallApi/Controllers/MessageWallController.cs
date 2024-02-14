using MessageWallApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MessageWallApi;

[ApiController]
[Route("api/[controller]")]
public class MessageWallController : ControllerBase
{
    private readonly ILogger<MessageWallController> _logger;

    public MessageWallController(ILogger<MessageWallController> logger)
    {
        _logger = logger;
    }

    // GET: api/MessageWall
    [HttpGet(Name = "GetMessages")]
    public string Get(string firstName = "", string lastName = "")
    {
        return $"Hello, {firstName} {lastName}!";
    }

    // POST: api/MessageWall
    [HttpPost(Name = "PostMessage")]
    public void Post([FromBody] MessageModel value)
    {
        _logger.LogInformation($"Message received: {value.Message}");
    }
}
