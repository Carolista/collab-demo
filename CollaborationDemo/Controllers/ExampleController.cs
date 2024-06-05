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
}
