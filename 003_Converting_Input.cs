using System;

namespace 003_Converting_Input
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, this program will tell you how many years passed since you were 18. Just enter your age: ");
      int userAge = Convert.ToInt32(Console.ReadLine());
      int since18 = (userAge - 18);
      Console.WriteLine("It's {0} years since you were 18.", since18);
    }
  }
}
