using Microsoft.AspNetCore.Mvc;

namespace CoreApiMiniProject;

[ApiController]
[Route("api/[controller]")]
public class PersonController
{
    private readonly ILogger<PersonController> _logger;

    public PersonController(ILogger<PersonController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "CreatePerson")]
    public void Post([FromBody] PersonModel person)
    {
        _logger.LogInformation("Person created: {0} {1} {2}", person.FirstName, person.LastName, person.IsActive);
    }
}
