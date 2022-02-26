using System;
namespace PierresBakery.Models
{
  public class Pastry : Oven
  {
    // properties
    public int Price{get; set;}
    public int PriceOfThree{get; set;}


    //constructor
    public Pastry(int pastryPrice, int dealPrice)
    {
      Price = pastryPrice;
      PriceOfThree = dealPrice;
    }

    public int CalculatePastryPrice(int inputQuantity)
    {
      return CalculatePrice(inputQuantity,Price,PriceOfThree);
    }

  }
}