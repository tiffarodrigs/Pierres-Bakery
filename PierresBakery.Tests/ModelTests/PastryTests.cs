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
  }
}