using Microsoft.AspNetCore.Mvc;
using BusinessTracker.Models;

namespace BusinessTracker.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() 
    { 
      return View(); 
    }
  }
}