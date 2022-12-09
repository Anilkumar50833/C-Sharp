using System;
using System.Threading;

public class MyThread {

	public void thread()
	{
		for (int x = 0; x < 2; x++) {
			Console.WriteLine("My Thread");
		}
	}
}

public class ThreadExample {

	public static void Main()
	{

		MyThread obj = new MyThread();
		Thread thr1 = new Thread(new ThreadStart(obj.thread));

		Console.WriteLine("ThreadState is : {0}", thr1.ThreadState);
		thr1.Start();

		Console.WriteLine("ThreadState is : {0}", thr1.ThreadState);
		thr1.Suspend();

		Console.WriteLine("ThreadState is : {0}",thr1.ThreadState);
		thr1.Resume();
        
		Console.WriteLine("ThreadState is : {0}",thr1.ThreadState);

	}
}
