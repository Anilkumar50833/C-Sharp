using System;

class booleanString {

	
	public static void Main()
	{
		bool Anil = false;
		bool kumar= true;

		string value1 = Anil.ToString();
		string value2 = kumar.ToString();

		Console.WriteLine("Anil.ToString() returns {0}", value1);
		Console.WriteLine("kumar.ToString() returns {0}", value2);
	}
}
