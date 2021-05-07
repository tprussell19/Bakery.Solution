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
      if (BreadCount >= 2)
      {
        int paidBread = BreadCount - (BreadCount / 3);
        int freeBread = BreadCount - paidBread;
        BreadTotalCost = BreadTotalCost - (freeBread * 5);
        GetFreeBread();
      }
    }

    public void GetFreeBread()
    {
      if (BreadCount % 3 == 2)
      {
        BreadCount += 1;
      }
    }
  }
}