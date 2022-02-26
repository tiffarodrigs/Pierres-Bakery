using System;
using PierresBakery.Models;
namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("Bread - $5\nPastry -$2");
      Console.WriteLine("Pierre's offers the following deal");
      Console.WriteLine("Bread: Buy 2, get 1 free");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5");
      Console.WriteLine("How Many Loaves of bread would you like to order?");
      int breadInput = int.Parse(Console.ReadLine());
      Console.WriteLine("How Many Loaves of pastries would you like to order?");
      int pastryInput = int.Parse(Console.ReadLine());

      //object instantiation has parameter (individual price ,deal price)
      Bread breadObj = new Bread(5,10);
      Pastry pastryObj = new Pastry(2,5);

      int totalBreadPrice = breadObj.CalculateBreadPrice(breadInput);
      int totalPastryPrice = pastryObj.CalculatePastryPrice(pastryInput);
      int totalOrderPrice = totalBreadPrice + totalPastryPrice;      
      Console.WriteLine("Your total price is $" +totalOrderPrice);
    
    }
  }
}