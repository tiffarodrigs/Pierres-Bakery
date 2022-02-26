using System;
namespace PierresBakery.Models
{
  public class Bread : Oven
  {
    // properties
    public int Price{get; set;}
    public int PriceOfThree{get; set;}


    //constructor
    public Bread(int breadPrice, int dealPrice)
    {
      Price = breadPrice;
      PriceOfThree = dealPrice;
    }
  
    public int CalculateBreadPrice(int inputQuantity)
    {
      return CalculatePrice(inputQuantity,Price,PriceOfThree);
    }
  }
}