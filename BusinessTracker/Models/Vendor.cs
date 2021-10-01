using System.Collections.Generic;

namespace BusinessTracker.Models
{
  public class Vendor
  {

    public string Name { get; }
    public Vendor(string vendorName)
    {
      Name = vendorName;
    }


    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
  }
}