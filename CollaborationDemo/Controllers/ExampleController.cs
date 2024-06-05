using Microsoft.AspNetCore.Mvc;

namespace CollaborationDemo;

[Route("/example")]
public class ExampleController : Controller
{
    [HttpGet("")]
    public IActionResult RenderExamplePage()
    {
        return View("Index");
    }

    [HttpGet("form")]
    public IActionResult RenderExampleFormPage()
    {
        return View("Form");
    }

    [HttpPost("form")]
    public IActionResult ProcessExampleFormPage(string name, string email, string comment)
    {       
        // TODO: Create future card for saving to database
        ViewBag.Name = name;
        return View("ThankYou");
    }
}
