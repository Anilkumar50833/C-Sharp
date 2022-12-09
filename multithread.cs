using System;
public class Multithread {

	public static void thread1()
	{

		for (int i = 0; i <= 10; i++) {

			Console.WriteLine("Thread1 is : {0}", i);
		}
	}
	public static void thread2()
	{
		for (int j = 0; j <= 10; j++) {

			Console.WriteLine("Thread2 is : {0}", j);
		}
	}
}
public class Program {
	static public void Main(string[] args)
	{
		Multithread.thread1();
		Multithread.thread2();
	}
}
