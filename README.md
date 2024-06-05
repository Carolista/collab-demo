# collab-demo

### TODOS REQUIRING CODE

Full list of TODOs [here](https://docs.google.com/document/d/1R8XIKSDRQgfDAE0Qmzrpmn7Ja0AuzFovTYY7PDEDeUM/edit)

#### TODO 2
Create `ExampleController` class and `Example/Index.cshtml` template (no partial yet) and code the action method for `GET /example` in the controller. Make a **commit**.

Template:
```
@{
    ViewData["Title"] = "Example Feature";
}

<h1>Example Feature</h1>

<p>This is our feature and it is awesome.</p>
```

Controller:
```
[Route("/example")]
public class ExampleController : Controller
{
    [HttpGet("")]
    public IActionResult RenderExamplePage()
    {
        return View("Index");
    }
}
```

Add a second link to the nav in `/Shared/_Layout.cshtml` that goes to the Example controller and Index template. Make **another commit** and **push** both commits.
```
<li class="nav-item">
    <a class="nav-link text-dark" asp-area="" asp-controller="Example" asp-action="Index">Example Feature</a>
</li>
```

#### TODO 3
Create `Example/Form.cshtml` template and code action methods for `GET /example/form` and `POST /example/form`. Have the post handler redirect to `/example` for now. Add a link on the /example Index template for the form

Form Template:
```
@{
    ViewData["Title"] = "Comment Form";
}

<h1>Questions, Comments & Suggestions</h1>

<p> Please give us your feedback on our app!</p>

<form method="POST">
    <div class="form-items">
        <input type="text" name="name" placeholder="Name" />
        <input type="email" name="email" placeholder="Email Address" />
        <textarea name="comment" minlength="1" maxlength="500" ></textarea>
        <button type="submit">Submit</button>
    </div>
</form>
```

Add to Controller:
```
[HttpGet("form")]
public IActionResult RenderExampleForm()
{
    return View("Form");
}

[HttpPost("form")]
public IActionResult ProcessExampleForm(string name, string email, string comment)
{
    // TODO on another branch: save to database
    return Redirect("/example");
}
```

Example/Index template:
```
<p>Click <a asp-controller="Example" asp-action="Form">here</a> to give us your comments and suggestions as to how to make this feature even more awesome!</p>
```


#### TODO 6
After suggestion is made on PR, move `<p>` with link to comment form to `/Shared/_LinkToCommentFormPartial.cshtml`, then put the following in its place in `Example/Index.cshtml`:
```
<partial name="/Views/Shared/_LinkToCommentFormPartial.cshtml" />
```

#### TODO 8
After suggestion is made on PR, add `required` keyword to all 3 inputs on Example/Form template

#### TODO 10 
After suggestion is made on PR, create Example/ThankYou template and update controller for `POST /example/form` 

ThankYou Template
```
<h1>Thank You, @ViewBag.Name!</h1>

<p>We have received your submission.</p>
```

`POST /example/form` Template:
```
[HttpPost("form")]
public IActionResult ProcessExampleForm(string name, string email, string comment)
{
    // TODO on another branch: save to database
    ViewBag.Name = name;
    return View("ThankYou");
}
```
