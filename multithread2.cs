using System;  
using System.Threading;  
public class MyThread  
{  
    public static void Thread1()  
    {  
        for (int i = 0; i < 10; i++)  
        {  
            Console.WriteLine("Thread1 is :"+i);  
        }  
    }  
}  
public class ThreadExample  
{  
    public static void Main()  
    {  
        Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));  
        t1.Start();  
    }  
}  