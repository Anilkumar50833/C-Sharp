using System;
namespace DefaultConstructorExample{
    class AAA{
    int num;
    string name;
    AAA()
    {
        Console.WriteLine("Constructor called");
    }
    public static void Main(){
        AAA aaa1 =new AAA();
        Console.WriteLine(aaa1.name);
         Console.WriteLine(aaa1.num);

    }
}
}