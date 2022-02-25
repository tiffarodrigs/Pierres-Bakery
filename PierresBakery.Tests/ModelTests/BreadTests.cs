using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread breadObj =  new Bread(1);
      Assert.AreEqual(typeof(Bread), breadObj.GetType());
    }

    [TestMethod]
    public void CalculateBreadPrice_CalculatesPriceOfOneBreadLoaf_int()
    {
      Bread breadObj =  new Bread(1);
      int result = breadObj.CalculateBreadPrice(1);
      Assert.AreEqual(5,result);
    }

    [TestMethod]
    public void CalculateBreadPrice_CalculatesPriceOfThreeBreadLoaf_int()
    {
      Bread breadObj =  new Bread(3);
      int result = breadObj.CalculateBreadPrice(3);
      Assert.AreEqual(10,result);
    }
  }
}