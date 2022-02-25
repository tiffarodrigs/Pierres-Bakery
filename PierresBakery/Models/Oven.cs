using System;
namespace PierresBakery.Models
{
  public class Oven
  {
    public Oven()
    {

    }
    public virtual int CalculateBreadPrice(int inputQuantity)
    {

      int price=1;
      int priceOfThree=1;
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
