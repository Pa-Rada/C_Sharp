using System;

namespace 004_Constants
{
  class Program
  {
    static void Main(string[] args)
    {
      /*implicitly typed variable*/
      var pi = 3.14;
      /*constant*/
      const double x = 2.19;
      double total = (pi + x);
      Console.WriteLine("{0}", total);
    }
  }
}
