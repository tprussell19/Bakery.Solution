using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void BreadOrderConstructor_CreateInstanceOfBreadOrder_BreadOrder()
    {
      BreadOrder newBreadOrder = new BreadOrder("1");
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }

    [TestMethod]
    public void GetBreadCount_ReturnsBreadCount_Int()
    {
      //Arrange
      string orderAmount = "1";
      BreadOrder newBreadOrder = new BreadOrder(orderAmount);

      //Act
      int result = newBreadOrder.BreadCount;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetBreadTotalCost_ReturnsBreadTotalCost_Int()
    {
      //Arrange
      string orderAmount = "1";
      BreadOrder newBreadOrder = new BreadOrder(orderAmount);

      //Act
      newBreadOrder.GetBreadCost();
      int result = newBreadOrder.BreadTotalCost;

      //Assert
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void GetBreadTotalCostWithPromo_ReturnsBreadTotalCost_Int()
    {
      //Arrange
      string orderAmount = "3";
      BreadOrder newBreadOrder = new BreadOrder(orderAmount);

      //Act
      newBreadOrder.GetBreadCost();
      int result = newBreadOrder.BreadTotalCost;

      //Assert
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void GiveFreeBreadWhenBreadCountHitsPromo_ReturnsBreadCount_Int()
    {
      //Arrange
      string orderAmount = "2";
      BreadOrder newBreadOrder = new BreadOrder(orderAmount);

      //Act
      newBreadOrder.GetFreeBread();
      int result = newBreadOrder.BreadCount;

      //Assert
      Assert.AreEqual(3, result);
    }
  }
}