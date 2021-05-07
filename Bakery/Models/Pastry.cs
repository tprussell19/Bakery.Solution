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
      PastryTotalCost = PastryCount * 2;
    }
  }
}