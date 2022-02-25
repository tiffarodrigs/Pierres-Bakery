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
      int price = 5;
      int priceOfThree = 10;
      int totalPrice;
      int mutipleOfThree = inputQuantity % 3;
      int offerQuatity;
      if(mutipleOfThree == 0)
      {
      offerQuatity = inputQuantity / 3;
      totalPrice = offerQuatity * priceOfThree;
      }
      else
      {
      totalPrice = inputQuantity * price;
      }
      return totalPrice;
    }

  }
}