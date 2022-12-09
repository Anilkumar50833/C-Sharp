using System;

class SampleCollection<T>
{
   private T[] arr = new T[100];
   public T this[int i]
   {
      get { return arr[i]; }
      set { arr[i] = value;}
   }
}

class Program
{
   static void Main()
   {
      var stringCollection = new SampleCollection<string>();
      stringCollection[0] = "Hello, World";
      stringCollection[1] = "1234";
      Console.WriteLine(stringCollection[0]);
   }
}