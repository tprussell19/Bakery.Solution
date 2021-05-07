namespace Bakery.Models
{
  public class BreadOrder
  {
    public int BreadCount { get; set; }
    public int BreadTotalCost { get; set; }

    public BreadOrder(string userInput)
    {
      BreadCount = int.Parse(userInput);
      BreadTotalCost = 0;
    }
  }

  public class PastryOrder
  {

  }
}