using System.Collections.Generic;

namespace BusinessTracker.Models
{
  public class Order
  {
    public string Description { get; set; }
    private static List<Order> _instances = new List<Order> { };
    
    public Order(string description)
    {
      Description = description;
    }
    public static List<Order> GetAll()
    {
        return _instances;
    }
  }
}