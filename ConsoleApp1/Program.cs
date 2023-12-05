// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;

// Datatype for userinput
string userInput;
bool goAgain = true;

// Console prompt


while (goAgain != false)
{
   startCalc();
}


void startCalc()
{
   Console.WriteLine("Hello Welcome! If you wish to enter a problem, enter 'start'(s) or 'quit'(q) to exit");
   string anotherRound = Console.ReadLine();

   if (anotherRound == "start" || anotherRound == "s")
   {
      Console.WriteLine("\nAlright lets go!\n");
      Operating();
   }
   else if (anotherRound == "quit" || anotherRound == "q")
   {
      Console.WriteLine("\nSee you next time!\n");
      goAgain = false;
   }
   else
   {
      Console.WriteLine("Please enter 'start'(s) or 'quit'(q) to exit!\n");
   }
}

void Operating()
{
   
   // Obtain first number
   Console.WriteLine("Please enter a number?");
   double num1 = Convert.ToDouble(Console.ReadLine());

   //Obtain second number
   Console.WriteLine("\nPlease enter a number?");
   double num2 = Convert.ToDouble(Console.ReadLine());

   // Obtain operator
   Console.WriteLine("\nPlease enter a number for the operartor");
   Console.WriteLine("1. Add(+)");
   Console.WriteLine("2. Subtract(-)");
   Console.WriteLine("3. Multiply(*)");
   Console.WriteLine("4. Divide(/)");
   Console.WriteLine("\nOperator: ");

   // Take user input for operator
   userInput = Console.ReadLine();

   bool opSelected = false;

   while (opSelected != true)
   {
      if (userInput == "1")
      {
         opSelected = true;
         Calculating.Add(num1, num2);
      }
      else if (userInput == "2")
      {
         opSelected = true;
         Calculating.Subtract(num1, num2);
      }
      else if (userInput == "3")
      {
         opSelected = true;
         Calculating.Multiply(num1, num2);
      }
      else if (userInput == "4")
      {
         opSelected = true;
         Calculating.Divide(num1, num2);
      }
      else
      {
         Console.WriteLine("Please enter an operator!\n");
      }
   }

}







