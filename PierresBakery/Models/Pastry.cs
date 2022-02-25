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
      int price = 2;
      int priceOfThree = 5;
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
          totalPrice = countOfThree * priceOfThree;
        }
        else
        {
          totalPrice = countOfThree * priceOfThree;
          totalPrice += threeRemainder * price;
        }

      }
      return totalPrice;
    }

  }
}