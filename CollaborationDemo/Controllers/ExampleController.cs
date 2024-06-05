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
    public IActionResult RenderExampleForm()
    {
        return View("Form");
    }

    [HttpPost("form")]
    public IActionResult ProcessExampleForm(string name, string email, string comment)
    {
        ViewBag.Name = name;
        return View("ThankYou");
    }

    // [HttpGet("thankyou")]
}
