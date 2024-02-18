using Microsoft.AspNetCore.Mvc;

namespace MVCMiniProject.Controllers;

public class AddressController : Controller
{

    private readonly ILogger<AddressController> _logger;

    public AddressController(ILogger<AddressController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    // GET: AddressController/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: AddressController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
