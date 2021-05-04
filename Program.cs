using System;
using System.Collections.Generic;
using Dealership.Models;
using Dealership.Models.Helpers;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car myCar = new Car();
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
    }
  }
}