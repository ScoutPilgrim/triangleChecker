using System;

namespace triangleCheck
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("TRIANGLE TRACKER");
      Console.WriteLine("Enter a length for side one...");
      string sideOneString = Console.ReadLine();
      int sideOne = int.Parse(sideOneString);
      Console.WriteLine("Enter a length for side two...");
      string sideTwoString = Console.ReadLine();
      int sideTwo = int.Parse(sideTwoString);
      Console.WriteLine("Enter a length for side three...");
      string sideThreeString = Console.ReadLine();
      int sideThree = int.Parse(sideThreeString);

      Triangle userTriangle = new Triangle(sideOne, sideTwo, sideThree);
      if (userTriangle.isTriangle())
      {
        Console.WriteLine("Your inputted triangle type: " + userTriangle.CheckType());
      } else
      {
        Console.WriteLine("Whoa, that's not a triangle.");
      }
    }
  }
}
