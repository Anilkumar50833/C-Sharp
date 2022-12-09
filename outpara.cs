using System;
public class anil
{
   public static int mu1val(params int[] num){
    int res=1;
    foreach(int j in num){
        res *=j;

    }
    return res;
   }
   static  void Main(string[] args){
    int x = mu1val(20,35,57,8,4,334);
    Console.WriteLine(x);
    x = mu1val (20,35);
     Console.WriteLine(x);
     x = mu1val(20);
      Console.WriteLine(x);
      x = mu1val();
       Console.WriteLine(x);
   }
}