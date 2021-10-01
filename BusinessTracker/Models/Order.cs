using System.Collections.Generic;

namespace BusinessTracker.Models
{
  public class Order
  {
    public string Description { get; set; }
    private static List<Order> _instances = new List<Order> { };
    public int Id { get; }

    public Order(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Order> GetAll()
    {
        return _instances;
    }
    public static void ClearAll()
    {
        _instances.Clear();
    }
  }
}