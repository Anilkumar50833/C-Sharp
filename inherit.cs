using System;
class Tank{
    double t_radius;
    double t_height;

public double Radius{
    get{
        return t_radius;
    }
    set{
        t_radius =value < 0 ? -value : value;
    }
}
public double Height
{
    get{
        return t_height;
    }
    set{
        t_height =value < 0 ? -value : value;
    }
}
public void DisplayDimension()
{
    Console.WriteLine(" radius tank is :"+Radius + "height of tank is :"+Height);
}
}
class AreaOfTank : Tank{
    string Color;
    public AreaOfTank(string c, double r , double h){
        Radius = r;
        Height = h;
        Color = c;
    }
    public double Area(){
        return 2*3.14 * Radius * Height;
    }
    public void DisplayColor(){
        Console.WriteLine("color tank is :"+Color);
    }
}
class AAA{
    static void Main(){
        AreaOfTank t1 = new AreaOfTank("yellow",5.3,23.0);
        t1.DisplayColor();
        t1.DisplayDimension();
        Console.WriteLine("area is :"+t1.Area());
    }
}