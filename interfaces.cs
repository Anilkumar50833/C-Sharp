using System;
class  interfaces
{
    interface Cars
{
  void Carmodel();
}
class Ferrai : Cars
{
  public void Carmodel() 
  {
    
    Console.WriteLine(" The model of ferrai is 2022");
  }
}
class Audi : Cars
{
    public void Carmodel(){
        Console.WriteLine(" The model of Audi is 2020");
    }
}
class Program 
{
  static void Main(string[] args) 
  {
    Ferrai myferrai = new Ferrai();  
    myferrai.Carmodel();
    Audi myaudi = new Audi();
    myaudi.Carmodel();
  }
}
}