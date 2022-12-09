using System;
namespace ConsoleApplication{
public struct Person
{
	public string Name;
	public int Age;
	public int Weight;

}

class ABC {
	static void Main(string[] args)
	{
		Person P1;
		P1.Name = "Keshav Gupta";
		P1.Age = 21;
		P1.Weight = 80;
		Console.WriteLine("data stored in name :"+P1.Name);
        Console.WriteLine("data stored in age :"+P1.Age);
        Console.WriteLine("data stored in  weight:"+P1.Weight);
	}
}
/*
public struct country{
    public string address;
    public int pincode;
    public string state;

}
class Struct{
    static void Main(string[] args){
        country C1;
        C1.address = "1-90 p.v ppuram village";
        C1.pincode = 517561;
        C1.state = "ANDHRA PRADESH";
        Console.WriteLine("data stored in address :"+C1.address);
        Console.WriteLine("data stored in age :"+C1.age);
        Console.WriteLine("data stored in  weight:"+C1.state);
    }
}
*/
}
