using System;
public class cal
{
    static void Main(string[] args)
    {
        Console.Write("Enter an num1: ");
        double num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter an operator: ");
        string op = Console.ReadLine();
        Console.Write("Enter an num2: ");
        double num2 = Convert.ToInt32(Console.ReadLine());
        if (op == "+")
        {
                  Console.WriteLine(num1 + num2);
        }
        else if (op == "-")
        {
                   Console.WriteLine(num1 - num2);
        } 
        else if (op == "/")
        {
                 Console.WriteLine(num1 / num2);
        }
         else if (op == "%")
        {
               Console.WriteLine(num1 % num2);
        } 
         else if (op == "*")
        {
               Console.WriteLine(num1 * num2);
        } 
        else 
        {
              Console.WriteLine("Invalid Operator");
        }
    }
}