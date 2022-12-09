// first in firstout
using System;
using System.Collections;

class Program {
    /*
	public static void Main()
	{

		Queue myQueue = new Queue();

		myQueue.Enqueue("Chandigarh");
		myQueue.Enqueue("Delhi");
		myQueue.Enqueue("Noida");
		myQueue.Enqueue("Himachal");
		myQueue.Enqueue("Punjab");
		myQueue.Enqueue("Jammu");

		Console.Write("Total number of elements in the Queue are : "+myQueue);

		Console.WriteLine(myQueue.Count);
	}
    */

	public static void Main()
	{
        
		Queue myQueue = new Queue();

		myQueue.Enqueue("anil kumar");
		myQueue.Enqueue("pavani");
		myQueue.Enqueue("shiresha");
		myQueue.Enqueue("swetha");
		myQueue.Enqueue("aniljosh");

		Object[] arr = myQueue.ToArray();

		foreach(Object obj in arr)
		{
			Console.WriteLine("the queue of obj is :"+obj);
		}
	}
}


