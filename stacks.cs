//first in last out
using System;
class Program{
    /*
    public static void Main(string [] args){

		Stack<int> numbers = new Stack<int>();
		numbers.Push(1);
		numbers.Push(2);    // in stack we can used push(); to add the elements
		numbers.Push(3);
		numbers.Push(4);

		foreach (var item in numbers)

			 Console.Write(item + ",");

	}
    */
    /*
    public static void Main()
	{
		Stack<int> myStack = new Stack<int>();
		myStack.Push(1);
		myStack.Push(2);
		myStack.Push(3);
		myStack.Push(4);

		Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

		if(myStack.Count > 0)
		{
			Console.WriteLine(myStack.Peek());
			Console.WriteLine(myStack.Peek());
		}
		
		Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);
	}
    */
    public static void Main()
	{
		Stack<int> myStack = new Stack<int>();
		myStack.Push(1);
		myStack.Push(2);
		myStack.Push(3);
		myStack.Push(4);
		
		Console.WriteLine(myStack.Contains(2)); 
		Console.WriteLine(myStack.Contains(10)); 
	}
}
