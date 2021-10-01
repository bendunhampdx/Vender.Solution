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
      string title = "Ben's Cafe";
      string description = "1 pastry";
      int price = 2;
      string date = "October 1st, 2021";
      Order newOrder = new Order(title, description, price, date);

      //Act
      string updatedTitle = "Kelly's Cafe";
      newOrder.Title = updatedTitle;
      string result1 = newOrder.Title;
      string updatedDescription = "1 loaf of bread";
      newOrder.Description = updatedDescription;
      string result2 = newOrder.Description;
      int updatedPrice = 4;
      newOrder.Price = updatedPrice;
      int result3 = newOrder.Price;
      string updatedDate = "October 2nd, 2021";
      newOrder.Date = updatedDate;
      string result4 = newOrder.Date;

      //Assert
      Assert.AreEqual(updatedTitle, result1);
      Assert.AreEqual(updatedDescription, result2);
      Assert.AreEqual(updatedPrice, result3);
      Assert.AreEqual(updatedDate, result4);
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
      string title01 = "Ben's Cafe";
      string title02 = "Kelly's Cafe";
      string description01 = "1 pastry";
      string description02 = "1 loaf of bread";
      int price01 = 2;
      int price02 = 4;
      string date01 = "October 1st, 2021";
      string date02 = "October 2nd, 2021";
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
     
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
      string title = "Ben's Cafe";
      string description = "1 pastry";
      int price = 2;
      string date = "October 1st, 2021";
      Order newOrder = new Order(title, description, price, date);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string title01 = "Ben's Cafe";
      string title02 = "Kelly's Cafe";
      string description01 = "1 pastry";
      string description02 = "1 loaf of bread";
      int price01 = 2;
      int price02 = 4;
      string date01 = "October 1st, 2021";
      string date02 = "October 2nd, 2021";
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }
  }
}