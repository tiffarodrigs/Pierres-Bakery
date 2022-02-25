using System;
namespace PierresBakery.Models
{
  public class Bread : Oven
  {
    // properties
    //public  int Quantity{get; set;}
      public int price = 5;
      public int priceOfThree = 10;
      public int totalPrice;

    //constructor
    public Bread()
    {

    }
    //Oven ovenObj= new Oven();
  
   // ovenObj.CalculateBreadPrice(int inputQuantity);

    // public int CalculateBreadPrice(int inputQuantity)
    // {

    //   int threeRemainder = inputQuantity % 3;
    //   int countOfThree = inputQuantity / 3; 
    //   if(inputQuantity<3)
    //   {
    //     totalPrice = price * inputQuantity;
    //   }
    //   else
    //   {
    //     if(threeRemainder == 0)
    //     {
    //       totalPrice =  priceOfThree * countOfThree;
    //     }
    //     else
    //     {
    //       totalPrice =  priceOfThree * countOfThree;
    //       totalPrice +=  price * threeRemainder;
    //     }
    //   }
    //   return totalPrice;
    // }

  }
}