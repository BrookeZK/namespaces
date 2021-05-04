using System;
using System.Collections.Generic;
// using Dealership.Models;
// using Dealership.Models.Helpers;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Dealership.Models.Helpers.Car myCar = new Dealership.Models.Helpers.Car();
      Dealership.Models.Car volkswagen = new Dealership.Models.Car("1974 Volkswagen Thing", 1100, 368792);
    }
  }
}