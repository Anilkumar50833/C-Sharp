using System;
class Boxes{
    
        public double length;
         public double heigth;
          public double breadth;
}
    class boxester{
        static void Main(string[] args){
            Box Box1 = new Box();
            Box Box2 = new Box();
            double volume = 0.0;
            Box1.length=5.0;
            Box1.heigth=4.6;
            Box1.breadth=6.0;

            Box2.length=4.0;
            Box2.heigth=5.6;
            Box2.breadth=2.0;

            volume = Box1.heigth*Box1.breadth*Box1.length;
            Console.WriteLine("volume of box1 is {0} :"+volume);
             volume = Box2.heigth*Box2.breadth*Box2.length;
            Console.WriteLine("volume of box2 is {0}:"+volume);
            Console.WriteLine();
        }
    }