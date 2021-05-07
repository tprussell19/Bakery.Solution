using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.TestTools
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
  }
}