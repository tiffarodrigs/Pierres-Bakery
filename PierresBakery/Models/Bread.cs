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
      int reminder = inputQuantity % 3;
      int offerQuantity = inputQuantity / 3;

      if(inputQuantity<3)
      {
        totalPrice = inputQuantity * price;
      }
      else
      {
        if(reminder == 0)
        {
          totalPrice = offerQuantity * priceOfThree;
        }
        else
        {
          totalPrice = offerQuantity * priceOfThree;
          totalPrice += reminder * price;
        }
      }
      return totalPrice;
    }

  }
}