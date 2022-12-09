using System;
class AAA{
    private string month;
    private int year;
    public AAA(AAA s){
        month =s.month;
        year =s.year;
        Console.WriteLine("anilkumar");
    }
public AAA(string month , int year){
    this.month = month;
    this.year = year;
}
public string Details{
    get{
        return "month : "+month.ToString()+"year : "+year.ToString();
               
    }
}
public static void Main(){
    AAA g1 =new AAA("june",2029);
    AAA g2 = new AAA(g1);
    AAA g3 = g1;
    Console.WriteLine(g2.Details);
    Console.WriteLine(g3.Details);
}
}