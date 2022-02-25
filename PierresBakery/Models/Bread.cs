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
      int threeRemainder = inputQuantity % 3;
      int countOfThree = inputQuantity / 3; 
      if(inputQuantity<3)
      {
        totalPrice = price * inputQuantity;
      }
      else
      {
        if(threeRemainder == 0)
        {
          totalPrice =  priceOfThree * countOfThree;
        }
        else
        {
          totalPrice =  priceOfThree * countOfThree;
          totalPrice +=  price * threeRemainder;
        }
      }
      return totalPrice;
    }

  }
}