using System;
class Singleton{
    public static readonly Singleton _obj = new Singleton();
    public void Display()
    {
        Console.WriteLine(true);
    }
    Singleton(){
        Console.WriteLine("inside constructor");
    }
}
class Demo{
    public static void Main(){
        Console.WriteLine("11111");
        Singleton._obj.Display();
        Console.WriteLine("22222");
    }
}