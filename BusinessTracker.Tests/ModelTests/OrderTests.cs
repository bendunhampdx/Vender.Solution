using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessTracker.Models;
using System.Collections.Generic;
using System;

namespace BusinessTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", 2, "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetProperties_ReturnsProperties_String()
    {
      //Arrange
      string title = "Ben's Cafe";
      string description = "1 pastry";
      int price = 2;
      string date = "October 1st, 2021";

      //Act
      Order newOrder = new Order(title, description, price, date);
      string result1 = newOrder.Title;
      string result2 = newOrder.Description;
      int result3 = newOrder.Price;
      string result4 = newOrder.Date;

      //Assert
      Assert.AreEqual(title, result1);
      Assert.AreEqual(description, result2);
      Assert.AreEqual(price, result3);
      Assert.AreEqual(date, result4);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "1 pastry";
      Order newOrder = new Order(title, description, price, date);

      //Act
      string updatedDescription = "1 loaf of bread";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string description01 = "1 pastry";
      string description02 = "1 loaf of bread";
      Order newOrder1 = new Order(description01);
      Order newOrder2 = new Order(description02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string description = "1 pastry";
      Order newOrder = new Order(description);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string description01 = "1 pastry";
      string description02 = "1 loaf of bread";
      Order newOrder1 = new Order(description01);
      Order newOrder2 = new Order(description02);

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }
  }
}