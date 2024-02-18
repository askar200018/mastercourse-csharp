using Microsoft.AspNetCore.Mvc;

namespace CoreApiMiniProject;

[ApiController]
[Route("api/[controller]")]
public class AddressController
{

    private readonly ILogger<AddressController> _logger;

    public AddressController(ILogger<AddressController> logger)
    {
        _logger = logger;
    }
    [HttpPost(Name = "CreateAddress")]
    public void Post([FromBody] AddressModel address)
    {
        _logger.LogInformation("Address created: {0} {1} {2}", address.City, address.Street, address.ZipCode);
    }

}
