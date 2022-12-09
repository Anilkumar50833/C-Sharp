using System;
using System.Text;
using System.Collections;
class AA{
    static void Concat1(String s1){
        String st ="forBBB";
        s1 = String.Concat(s1,st);
        Console.WriteLine(s1);
    }
    public static void Concat2(StringBuilder s2){
        s2.Append("forBBB");
    }
    public static void Main(string[] args){
        String s1 = "AAAA";
        Concat1(s1);
        Console.WriteLine("using string class :"+s1);
        StringBuilder s2 = new StringBuilder("BBB");
        Concat2(s2);
        Console.WriteLine("using string class :"+s2);
    }

    
}