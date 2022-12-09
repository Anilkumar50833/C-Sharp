using System;  
using System.Threading;  
public class MyThread  
{  
    public void Thread1()  
    {  
        for (int i = 0; i < 5; i++)  
        {  
            Console.WriteLine("thread is :"+i);  
            Thread.Sleep(1000);  
        }  
    }  
}  
public class ThreadExample  
{  
    public static void Main()  
    {  
        MyThread mt = new MyThread();  
        Thread t1 = new Thread(new ThreadStart(mt.Thread1));  
        Thread t2 = new Thread(new ThreadStart(mt.Thread1));  
        Thread t3 = new Thread(new ThreadStart(mt.Thread1));  
        t1.Start();  
         t1.Join(); // calling the thread and waiting for the other thread to calling the joined.
        t2.Start();  
        t3.Start();  
    }  
}

/*
using System;
using System.Threading;

public class Ex
{
   static Thread thread1, thread2;
   
   public static void Main()
   {
      thread1 = new Thread(ThreadProc);
      thread1.Name = "Thread1";
      thread1.Start();
      
      thread2 = new Thread(ThreadProc);
      thread2.Name = "Thread2";
      thread2.Start();   
   }

   private static void ThreadProc()
   {
      Console.WriteLine("\nCurrent thread: {0}", Thread.CurrentThread.Name);
      if (Thread.CurrentThread.Name == "Thread1" && 
          thread2.ThreadState != ThreadState.Unstarted)
         thread2.Join();
      
      Thread.Sleep(1000);
      Console.WriteLine("\nCurrent thread: {0}", Thread.CurrentThread.Name);
      Console.WriteLine("Thread1: {0}", thread1.ThreadState);
      Console.WriteLine("Thread2: {0}\n", thread2.ThreadState);
   }
}
*/