using Microsoft.AspNetCore.Mvc;
using System;

namespace BasicCoreWebsite.Controllers {
  public class BasicController: Controller {
    public IActionResult Index(string name = "Stack Overflow") => Content(BasicFrameworkLibrary.BasicClass.SayHello(name));
    public IActionResult Configuration() => Content(String.Join(", ", BasicFrameworkLibrary.BasicClass.GetAppSettings()));
  }
}