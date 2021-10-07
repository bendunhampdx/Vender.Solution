
using System.Collections.Generic;

namespace BusinessTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instance = new List<Order> { };

    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instance.Add(this);
      Id = _instance.Count;
    }
    public static List<Order> GetAll()
    {
        return _instance;
    }
    public static void ClearAll()
    {
        _instance.Clear();
    }

  public static Order Find(int searchId)
    {
      return _instance[searchId-1];
    }
  }
}