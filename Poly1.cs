using System;
public class web{
    string name = "AAAAAAAAA";
    public virtual void showdata()
    {
        Console.WriteLine("website name :"+name);
    }
}
class stream : web{
    string s ="computer science";
    public override void showdata()
    {
        base.showdata();
        Console.WriteLine("about :"+s);
    }
}
class BBB{
    static void Main(){
        stream E =new stream();
        E.showdata();
    }
}