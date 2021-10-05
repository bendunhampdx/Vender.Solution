using Microsoft.AspNetCore.Mvc;

namespace BusinessTracker.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
