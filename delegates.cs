using System;
namespace GeeksForGeeks {
class Delegate
{
public delegate void addnum(int a, int b);
public delegate void subnum(int a, int b);
public delegate void mutlipication(int a ,int b);
    public void mutlipication(int a , int b){
        Console.WriteLine("the multi of two numbers:{0}",a*b);
    }
	public void sum(int a, int b)
	{
		Console.WriteLine("The add two numbers is :{0}", a + b);
	}
	public void subtract(int a, int b)
	{
		Console.WriteLine("The Sub two numbers is :{0}", a - b);
	}
public static void Main(String []args)
{
	Geeks obj = new Geeks();
	addnum del_obj1 = new addnum(obj.sum);
	subnum del_obj2 = new subnum(obj.subtract);
    mutlipication del_obj3 =new mutlipication(obj.mutlipication);
	del_obj1(100, 40);
	del_obj2(100, 60);
    del_obj3(20 ,5);
}
}
}
