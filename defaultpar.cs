using System;
public class aa{
    static public void detail(string ename,int eid,string bgrp ="a+", string dept="TTD"){
        Console.WriteLine("employee name {0}",ename);
         Console.WriteLine("employee id {0}",eid);
          Console.WriteLine("employee group {0}",bgrp);
           Console.WriteLine("employee dept{0}",dept);
    }
     static public void Main(){
        detail("xyz",123);
        detail("abc",456 , "b+");
        detail("def",789,"b+", "software developer");
     }

}