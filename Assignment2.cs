using System;
using System.Collections;
// parent class 111
interface A {
	void courses();
}
class A1 : A {
    public void courses()
	{
        Console.WriteLine("HTML");
        Console.WriteLine("CSS");
        Console.WriteLine("JS");
        Console.WriteLine("BS");
        Console.WriteLine("REACT");

	}
}
// parent class 222
interface B {
	void Webtech();
}
class B1 : B {
	public void Webtech()
	{
         Console.WriteLine("FULL STACK");
        Console.WriteLine("FRONT-END ");
         Console.WriteLine("BACK-END ");
	}
}
//child class
class ANIL: A1, B1 
{
	A1 obj1 = new A1();
	B1 obj2 = new B1();

	public void courses()
	{
		obj1.courses();
	}

	public void Webtech()
	{
		obj2.Webtech();
	}
}
public class Program {

	static public void Main()
	{
		ANIL obj = new ANIL();
		obj.courses();
		obj.Webtech();
	}
}
