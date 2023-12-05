using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

public static class Calculating
{
   // Methods

   public static void Compared(double num1, double num2)
   {
      if (num1 < num2)
      {
         Console.WriteLine($"\nResult: {num1} is less than {num2}!");
      } else if (num1 > num2)
      {
         Console.WriteLine($"\nResult: {num1} is greater than {num2}!");
      } else if (num1 == num2)
      {
         Console.WriteLine($"\nResult: {num1} is equal to {num2}!");
      } else
      {
         Console.WriteLine("\nUnknown Unknown...");
      }

   }
   // Add and show resut
    public static void Add(double num1, double num2)
    {
      double added = num1 + num2;

      Compared(num1, num2);
      Console.WriteLine($"Result: {num1} + {num2} = {added}\n");
    }

   // Subtract
    public static void Subtract(double num1, double num2)
    {
      double added = num1 - num2;

      Compared(num1, num2);
      Console.WriteLine($"Result: {num1} - {num2} = {added}\n");
    }

   // Multiply
    public static void Multiply(double num1, double num2)
    {
      double added = num1 * num2;

      Compared(num1, num2);
      Console.WriteLine($"Result: {num1} * {num2} = {added}\n");
    }

   // Divide
    public static void Divide(double num1, double num2)
    {
      double added = num1 / num2;

      Compared(num1, num2);
      Console.WriteLine($"Result: {num1} / {num2} = {added}\n");
    }


}