using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    Pastry pastryObj =  new Pastry(2,5);
    [TestMethod]
    public void PastryConstructor_CreateAPastryContructor_Pastry()
    {
      Assert.AreEqual(typeof(Pastry), pastryObj.GetType());
    }

    [TestMethod]
    public void CalculatePastryPrice_CalculatePriceOfOnePastry_int()
    {
      int result = pastryObj.CalculatePastryPrice(1);
      Assert.AreEqual(2,result);
    }

    [TestMethod]
    public void CalculatePastryPrice_CalculatePriceOfThreePastry_int()
    {
      int result = pastryObj.CalculatePastryPrice(3);
      Assert.AreEqual(5,result);
    }

    [TestMethod]
    public void CalculatePastryPrice_CalculatePriceOfFivePastry_int()
    {
      int result = pastryObj.CalculatePastryPrice(5);
      Assert.AreEqual(9,result);
    }
    [TestMethod]
    public void CalculatePastryPrice_CalculatePriceOfSixPastry_int()
    {
      int result = pastryObj.CalculatePastryPrice(6);
      Assert.AreEqual(10,result);
    }
  }
}