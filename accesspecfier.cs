using System;
class A{
    public void F(){
        console.WriteLine("A.F");
    }
}
class B{
    public void G(){
        console.WriteLine("B.G");
    }
}
class test{
   static void Main(){
     B b =new B();
    b.F();
    b.G();
    A a = b;
    A.F();
    Console.ReadLine();
   }


}