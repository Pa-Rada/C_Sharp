using System;

namespace 005_Arithmetic_Operators
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 15;
      int y = 9;
      var z = (x/y);
      Console.WriteLine("{0}", z);
      /*Result: 1*/
      int a = 25%7;
      Console.WriteLine(a);
    }
  }
}
