namespace Bakery
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

    public void GetBreadCost()
    {
      BreadTotalCost = BreadCount * 5;
      // if (BreadCount >= 2)
      // {
      //   int freeBread = BreadCount - (BreadCount / 2);
      //   BreadTotalCost = BreadTotalCost - (freeBread * 5);
      // }
    }
  }
}