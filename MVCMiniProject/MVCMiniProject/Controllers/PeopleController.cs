using Microsoft.AspNetCore.Mvc;

namespace MVCMiniProject.Controllers;

public class PeopleController : Controller
{
    private readonly ILogger<PeopleController> _logger;

    public PeopleController(ILogger<PeopleController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public ActionResult Create()
    {
        return View();
    }

    // POST: PeopleController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
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
