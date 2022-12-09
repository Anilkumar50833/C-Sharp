using System;
class Clone {
	public static void Main(string[] args)
	{
		 string s1 = "Anil kumar";
         Console.WriteLine("String : {0}", s1);
		 string s2 = (String)s1.Clone();
		 Console.WriteLine("Clone String : {0}", s2);
	}
}
