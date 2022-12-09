using System;
public class outer_class{
    public void method1(){
        Console.WriteLine("outer class method");

    }
    public class Inner_class{
        public static int i=10;
    }
}
public class Exclass : outer_class{
    public void func(){
         Console.WriteLine(" method of drived class");
    }
}
public class AAA{
    static public void Main(){
        Exclass obj = new Exclass();
        obj.func();
        obj.method1();
    }
}