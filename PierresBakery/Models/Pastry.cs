using System;
namespace PierresBakery.Models
{
  public class Pastry
  {
    // properties
    public int Quantity{get; set;}

    //constructor
    public Pastry(int quantity)
    {
      Quantity = quantity;
    }

    public int CalculatePastryPrice(int inputQuantity)
    {
      return 0;
    }

  }
}