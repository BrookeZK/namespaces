
namespace Dealership.Models 
{
  public class Car
  {
    // field
    private string _makeModel; //private field

    public string MakeModel //public property
    {
        get
        {
            return _makeModel; // field performing 'read' action
        }
        set
        {
            _makeModel = value; // field performing 'write' action
        }
    }
    // Auto-Implemented property
    // public string MakeModel { get; set; }
    private int _price;
    private int _miles;

    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }
  }

}