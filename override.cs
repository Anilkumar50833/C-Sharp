using System;

class baseClass{
    public virtual void show(){
        Console.WriteLine("base class");
    }
}
class derived : baseClass{
    public override void show()
    {
       
            Console.WriteLine("child class");
        
    }
}
 class BBB{
    public static void Main(){
        baseClass obj;
        obj = new baseClass();
        // base calss
        obj.show();
        // child class
        obj = new derived(); // child class
        obj.show();

    }
 }