using System;
public class Generics{
	public void Display <TypeOfValue> (string msg, TypeOfValue value)
	{
		Console.WriteLine("msg is {0} , The value is :{1}", msg, value);
	}
}
public class Example {
		public static  int Main()
	{
		
		Generics p = new Generics();
		p.Display<int>("Integer", 122);
		p.Display<String>("String", "Anilkumar");
		p.Display<float>("float", 255.67F);
		return 0;
	}
}
