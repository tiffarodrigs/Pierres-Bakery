using System;
namespace PierresBakery.Models
{
  public class Bread
  {
    // properties
    public int Quantity{get; set;}

    //constructor
    public Bread(int quantity)
    {
      Quantity = quantity;
    }

    public int CalculateBreadPrice(int inputQuantity)
    {
    return 0;
    }

  }
}