using Microsoft.AspNetCore.Mvc;
using BusinessOrganizer.Models;
using System.Collections.Generic;

namespace BusinessOrganizer.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/venders/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendors vendor = Vendor.Find(vendorId);
      return View(vendor);
    }
    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }

  }
}