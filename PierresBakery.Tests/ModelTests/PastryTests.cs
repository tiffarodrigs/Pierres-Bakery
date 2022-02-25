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
      Pastry pastryObj =  new Pastry();
      Assert.AreEqual(typeof(Pastry), pastryObj.GetType());
    }
  }
}