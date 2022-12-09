using System;
class program{
    static void Main(string[] args){
        DateTime today = DateTime.Now;
        Console.WriteLine("shortdate:{0:d}",today);
        Console.WriteLine("Longdate:{0:D}",today);
        Console.WriteLine("shorttime:{0:t}",today);
        Console.WriteLine("Longtime:{0:T}",today);
        Console.WriteLine("Month:{0:M}",today);
        Console.WriteLine("Year:{0:Y}",today);
    }
}