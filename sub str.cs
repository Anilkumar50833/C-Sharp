using System;
class Geeks 
{
	public static void Main()
	{

		String str = "Anilkumar";
        String str2 ="Jasawanth kumar";
        Console.WriteLine("String : " + str2);
        String ani= str2.Substring(4);
         Console.WriteLine(ani);
        Console.WriteLine("Sub String2: " + str2.Substring(8));

		Console.WriteLine("String : " + str);

		// retrieve the substring from index 5
		Console.WriteLine("Sub String1: " + str.Substring(5));

		// retrieve the substring from index 8
		Console.WriteLine("Sub String2: " + str.Substring(8));
	}
}