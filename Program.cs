using System;
using System.Collections.Generic;
// using Dealership.Models;
// using Dealership.Models2;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Dealership.Models2.Car myCar = new Dealership.Models2.Car();
      Dealership.Models.Car volkswagen = new Dealership.Models.Car("1974 Volkswagen Thing", 1100, 368792);
    }
  }
}