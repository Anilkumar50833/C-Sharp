using System;
public  class outer_class{
    public int number=12222;
    public static int number1=233333333;
    public class Inner_class{
        public void method1(){
            outer_class obj = new outer_class();
        }
    }
}
public class AAA{
    static public void Main(){
        outer_class.Inner_class.method1();
    }
}