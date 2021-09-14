using System;

namespace 006_Modulus
{
  class Program
  {
    static void Main(string[] args)
    {
      /*Assignment: You are organizing a party for some guests. All of them like beer.
      Write a program to take the number of beer bottles you bought as input and calculate how many bottles will be left after equally distributing the beer among all guests.*/
      Console.WriteLine("Greetings, if you are organizing a party and want to equally distribute bottles of beer to your guests, I can count for you how much bottles will be left - depending on number of guests and of course number of beer bottles you bought. So, how many guests will come?");
      int guests = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("And number of beer bottles you bought?");
      int beerBottles = Convert.ToInt32(Console.ReadLine());
      int bottlesLeft = (beerBottles%guests);
      Console.WriteLine("Thank you! There will be {0} guests coming over and you bought {1} beer bottles, so there will be in the end {2} beer bottles left. Thank you for using this program.", guests, beerBottles, bottlesLeft);
    }
  }
}
