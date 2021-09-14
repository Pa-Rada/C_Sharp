using System;

namespace 002_Getting_Input
{
  class Program
  {
    static void Main(string[] args)
    {
      string userName;
      Console.WriteLine("Hello, what is your name?");
      userName = Console.ReadLine();
      string userFrom;
      Console.WriteLine("And where are you from?");
      userFrom = Console.ReadLine();
      Console.WriteLine("Hello {0} from {1}!", userName, userFrom);
    }
  }
}
