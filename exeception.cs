using System;
public class Example{
    /* public static void Main(string[] args){
        try
        {
            int a = 10;
            int b= 10;
            int c = a/b;
            Console.WriteLine("after division is :{0}",c);
        }
        catch (Exception e){
            Console.WriteLine("11111");
             Console.WriteLine(e);
              Console.WriteLine("44444");
        } 
       Console.WriteLine("Rest of the code......");
       
    }
    */
    public static void Main(string[] args){
        try
        {
            int a = 10;
            int b= 10;
            int c = a/b;
            Console.WriteLine("after division is :{0}",c);
        }
        catch (Exception e){
            Console.WriteLine(e);
            }
        finally {
                Console.WriteLine("Finally block is exception......");
                Console.WriteLine("Rest of code......");
          
            }         
}
}