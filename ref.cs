using System;
public class ref
{
    static void Main()
    {
        string val ="dog";
        compareValue(ref val);
        Console.WriteLine(val);
    }
    static void compareValue(ref string val1)
    {
        if(val1==dog)
        {
            console.WriteLine("successfull matched");
        }
        val1="lucky cat";
    }

}
