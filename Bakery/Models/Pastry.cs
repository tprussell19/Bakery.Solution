namespace Bakery
{
  public class PastryOrder
  {
    public int PastryCount { get; set; }
    public int PastryTotalCost { get; set; }

    public PastryOrder(string userInput)
    {
      PastryCount = int.Parse(userInput);
      PastryTotalCost = 0;
    }

    public void GetPastryCost()
    {
      if (PastryCount >= 3)
      {
        PastryTotalCost = (((PastryCount / 3) * 5) + ((PastryCount % 3) * 2));
      }
      else
      {
        PastryTotalCost = PastryCount * 2;
      }
    }
  }
}