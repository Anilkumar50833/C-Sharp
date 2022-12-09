using System;
class program{
    static void Main(string[] args){
        char c='$';
        int i=125;
        Console.WriteLine("number:{0:N}",125);
        Console.WriteLine("Scientific:{0:E}",125);
        Console.WriteLine("Currency:{0:c}{1}",c,i);
        Console.WriteLine("hexadecimal:{0:X}",125);
    }
}