using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessTracker.Models;
using System.Collections.Generic;
using System;

namespace BusinessTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "1 pastry";

      //Act
      Order newOrder = new Order(description);
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

  }
}