using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Business_Mock_ups.Models;

namespace Business_Mock_ups.Controllers;

public class MockupsController : Controller
{
    private readonly ILogger<MockupsController> _logger;

    public MockupsController(ILogger<MockupsController> logger)
    {
        _logger = logger;
    }
    public IActionResult Gallery()
    {
        return View();
    }
    
       [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}