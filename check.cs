using System;  
namespace Program  
{  
    class Program 
    {  
        static void Main(string[] args)   
        {  
            checked  
            {  
                int val = int.MaxValue;  
                Console.WriteLine(val + 2);  
            }  
        }  
        /*
         static void Main(string[] args)   
        {  
            unchecked  
            {  
                int val = int.MaxValue;  
                Console.WriteLine(val + 2);  
            }  
        }  
        */
    }  
}