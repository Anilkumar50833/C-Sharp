using System;
class anil{
static public void Main(string[] args)
{
  Console.WriteLine("arguments : " +args.Length);
  Console.WriteLine("supplied Arguments are");
     
		foreach(Object obj in args)
		{
			 Console.WriteLine(obj);
		 }
}
}