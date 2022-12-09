using System;
using System.Collections.Generic;
	
public class Program
{/*
	public static void Main(string[] args)
	{
		Queue<string> strQ = new Queue<string>();
		strQ.Enqueue("H");
		strQ.Enqueue("e");
		strQ.Enqueue("l");
		strQ.Enqueue("l");
		strQ.Enqueue("o");

		Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5

		if(strQ.Count > 0){
			Console.WriteLine(strQ.Peek()); 
			Console.WriteLine(strQ.Peek());         //first letter can only prints H... bwc of peek();
			Console.WriteLine(strQ.Peek()); 
		}

		Console.WriteLine("Total elements: {0}", strQ.Count); 
	}
*/
    public static void Main()
	{
		Queue<int> callerIds = new Queue<int>();
		callerIds.Enqueue(1);
		callerIds.Enqueue(2);
		callerIds.Enqueue(3);       // contains() either check element is thier in queue or not ....
		callerIds.Enqueue(4);

		Console.WriteLine(callerIds.Contains(2)); 
		Console.WriteLine(callerIds.Contains(10)); 

	}
}