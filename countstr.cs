using System;  
                      
public class Countstr  
{  
    public static void Main()  
    {  
        String str1 = "Anilkumar";  
        int count = 0;  
        for(int i = 0; i < str1.Length; i++)
        {  
            if(str1[i] != ' ')
            {
                      count++;  
            } 
        }  
        Console.WriteLine("The total count string is : " + count);  
    }  
} 