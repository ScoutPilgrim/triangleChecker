using System;

namespace triangleCheck
{
  class Triangle
  {
    int SideOne;
    int SideTwo;
    int SideThree;
    public Triangle(int sideOne, int sideTwo, int sideThree)
    {
      SideOne = sideOne;
      SideTwo = sideTwo;
      SideThree = sideThree;
    }
    public int GetSideOne()
    {
      return SideOne;
    }
    public int GetSideTwo()
    {
      return SideTwo;
    }
    public int GetSideThree()
    {
      return SideThree;
    }

    public bool isTriangle()
    {
      return (SideOne < SideTwo + SideThree && SideTwo < SideOne + SideThree && SideThree < SideOne + SideTwo);
    }

    public string CheckType()
    {
      if (SideOne == SideTwo && SideTwo == SideThree)
      {
        return "Equilateral";
      }
      else if (SideOne == SideTwo || SideOne == SideThree || SideTwo == SideThree)
      {
        return "Isosceles";
      }
      else
      {
        return "Scalene";
      }
    }

  }
}
