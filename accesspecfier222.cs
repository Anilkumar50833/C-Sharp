using System;
 
namespace Protected_Internal
{
    class access
    {
       
        protected internal string name;
        public void print()
        {
            Console.WriteLine("\nMy name is " + name);
        }
    }
 
 
    class Program
    {
        static void Main(string[] args)
        {
            access ac = new access();
            Console.Write("Enter your name:\t");
           
            ac.name = Console.ReadLine();
            ac.print();
            Console.ReadLine();
        }
    }
}