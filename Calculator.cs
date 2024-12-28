using System;
using System.linq;
using System.text;


namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      int num1;
      int num2
      int result;
      string answer;

      Console.WriteLine("Welcome to Akshi's Calculator!");
      Console.WriteLine("Please enter your first number");

      num1=Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Please enter your second number: ");

      num2=Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("What type of BODMAS operation would you like, +,-,/, *");
      Console.WriteLine("Please enter the sign corresponding to operation");

      answer=Console.ReadLine();

      if (answer = "+")
      {
        result = num1 + num2;
      }
      else if (answer = "-")
      {
        result = num1 - num2;
      }
      else if (answer = "*")
      {
        result = num1 * num2;
      }
      else if (answer = "/")
      {
        result = num1/num2;
      }

      Console.WriteLine("The result is: ", result);
      Console.WriteLine("Thank you using the calculator")

      Console.ReadKey()
      }
  }
}
        
