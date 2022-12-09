using System;
using System.Collections.Generic;

class Program {
    	static public void Main()
	{

		HashSet<string> myhash1 = new HashSet<string>();
		myhash1.Add("C");
		myhash1.Add("C++");
		myhash1.Add("C#");
		myhash1.Add("Java");
		myhash1.Add("Ruby");
		Console.WriteLine("Elements of myhash1:");

		foreach(var val in myhash1)
		{
			Console.WriteLine(val);
		}

		HashSet<int> myhash2 = new HashSet<int>() 
        { 10,100,1000,10000,100000};
	
		Console.WriteLine("Elements of myhash2:");
		foreach(var value in myhash2)
		{
			Console.WriteLine(value);
		}
	}
}
