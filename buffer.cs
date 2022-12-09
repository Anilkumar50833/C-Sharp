using System;
using System.Text;
class buffer{
    static void Main()
    {
        StringBuilder s = new StringBuilder("hello anil",50);
        s.Insert(7,"aaaaaa");
        Console.WriteLine(s);

        /*
        StringBuilder sb = new StringBuilder();
        sb.Append("Hello ");
        sb.AppendLine("World!");
        sb.AppendLine("Hello C#");
        Console.WriteLine(sb);

        */
    
    }
}