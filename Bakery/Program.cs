using Bakery;
using System;

namespace Bakery.Solutions
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Hello, welcome to Pierre's Bakery!");
      Console.WriteLine("We are currently running a special on our fresh breads and pastries!");
      Console.WriteLine("Bread: $5 each | Buy 2, get 1 FREE!");
      Console.WriteLine("Pastries: $2 each | 3 for $5!");
      BuyStuff();
    }

    private static int _totalCost = 0;

    static void BuyStuff()
    {
      Console.WriteLine("Would you like to purchase anything? (Y/N)");
      string buyStuff = (Console.ReadLine()).ToLower();
      if (buyStuff == "y")
      {
        BuyBread();
        BuyPastry();
        if (_totalCost > 0)
        {
          Console.WriteLine("Your total today is $" + _totalCost + ".");
        }
        Console.WriteLine("Thank you for choosing Pierre's Bakery! We hope to see you again soon!");
      }
      else if (buyStuff == "n")
      {
        Console.WriteLine("We hope to see you again soon!");
      }
      else
      {
        Console.WriteLine("Please enter 'Y' or 'N' only");
        BuyStuff();
      }
    }

    static void BuyBread()
    {
      Console.WriteLine("Would you like to buy some bread? (Y/N)");
      string buyBread = (Console.ReadLine()).ToLower();
      if (buyBread == "y")
      {
        Console.WriteLine("How many loaves of bread would you like?");
        string userInput = Console.ReadLine();
        int parsedInput = int.Parse(userInput);
        if (parsedInput <= 0)
        {
          Console.WriteLine("Please enter a valid number.");
          BuyBread();
        }
        else
        {
          BreadOrder newBreadOrder = new BreadOrder(userInput);
          newBreadOrder.GetBreadCost();
          _totalCost += newBreadOrder.BreadTotalCost;
          Console.WriteLine("That will be $" + newBreadOrder.BreadTotalCost + " for " + newBreadOrder.BreadCount + " loaves of bread!");
        }
      }
      else if (buyBread == "n")
      {
      }
      else
      {
        Console.WriteLine("Please enter 'Y' or 'N' only");
        BuyBread();
      }
    }

    static void BuyPastry()
    {
      Console.WriteLine("Would you like to buy some pastries? (Y/N)");
      string buyPastry = (Console.ReadLine()).ToLower();
      if (buyPastry == "y")
      {
        Console.WriteLine("How many pastries would you like?");
        string userInput = Console.ReadLine();
        int parsedInput = int.Parse(userInput);
        if (parsedInput <= 0)
        {
          Console.WriteLine("Please enter a valid number.");
          BuyPastry();
        }
        else
        {
          PastryOrder newPastryOrder = new PastryOrder(userInput);
          newPastryOrder.GetPastryCost();
          _totalCost += newPastryOrder.PastryTotalCost;
          Console.WriteLine("That will be $" + newPastryOrder.PastryTotalCost + " for " + newPastryOrder.PastryCount + " pastries!");
        }
      }
      else if (buyPastry == "n")
      {
      }
      else
      {
        Console.WriteLine("Please enter 'Y' or 'N' only");
        BuyPastry();
      }
    }
  }
}
