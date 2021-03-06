using System;

namespace TriangleTest
{
  public class Triangle
  {
    public string TriangleType(int side1, int side2, int side3)
    {
      if ((side1 + side2 < side3) || (side1 + side3 < side2) || (side2 + side3 < side1))
      {
        return "Invalid triangle!";
      }
      else if (side1 == side2 && side2 == side3 && side1 == side3)
      {
        return "Equilateral";
      }
      else if (side1 == side2 || side1 == side3 || side2 == side3)
      {
        return "Isosceles";
      }
      else if (side1 != side2 && side2 != side3 && side1 != side3)
      {
        return "Scalene";
      }
      else
      {
        return "Error something went wrong!";
      }
    }
    public static void Main()
    {
      Console.WriteLine("Enter Side 1 Length: ");
      int side1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Side 2 Length: ");
      int side2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Side 3 Length: ");
      int side3 = int.Parse(Console.ReadLine());
      Triangle userTriangle = new Triangle();
      Console.WriteLine(userTriangle.TriangleType(side1, side2, side3));
    }
  }
}