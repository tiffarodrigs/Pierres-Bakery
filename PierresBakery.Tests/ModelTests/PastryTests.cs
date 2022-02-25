using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateAPastryContructor_Pastry()
    {
      Pastry pastryObj =  new Pastry(1);
      Assert.AreEqual(typeof(Pastry), pastryObj.GetType());
    }

    [TestMethod]
    public void CalculatePastryPrice_CalculatePriceOfOnePastry_int()
    {
      Pastry pastryObj =  new Pastry(1);
      int result = pastryObj.CalculatePastryPrice(1);
      Assert.AreEqual(2,result);
    }

    [TestMethod]
    public void CalculatePastryPrice_CalculatePriceOfThreePastry_int()
    {
      Pastry pastryObj =  new Pastry(3);
      int result = pastryObj.CalculatePastryPrice(3);
      Assert.AreEqual(5,result);
    }

    [TestMethod]
    public void CalculatePastryPrice_CalculatePriceOfFivePastry_int()
    {
      Pastry pastryObj =  new Pastry(5);
      int result = pastryObj.CalculatePastryPrice(5);
      Assert.AreEqual(9,result);
    }
    [TestMethod]
    public void CalculatePastryPrice_CalculatePriceOfSixPastry_int()
    {
      Pastry pastryObj =  new Pastry(6);
      int result = pastryObj.CalculatePastryPrice(6);
      Assert.AreEqual(10,result);
    }
  }
}