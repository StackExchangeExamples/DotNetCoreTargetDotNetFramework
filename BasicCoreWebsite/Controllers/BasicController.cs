using Microsoft.AspNetCore.Mvc;

namespace BasicCoreWebsite.Controllers {
  public class BasicController: Controller {
    public IActionResult Index(string name = "Stack Overflow") {
      return Content(BasicFrameworkLibrary.BasicClass.SayHello(name));
    }
  }
}