using System;

namespace class5
{
    internal class Program
    {

        /*1.public static void Main()
          {
              int[] intArray;
              intArray = new int[5];
              intArray[0] = 10;
              intArray[1] = 20;
              intArray[2] = 30;
              intArray[3] = 40;
              intArray[4] = 50;
              Console.WriteLine("for loop ");
              for (int i=0; i<intArray.Length; i++)
              {
                  Console.WriteLine("" + intArray[i]);
                  Console.WriteLine("");
                  Console.WriteLine("for-each loop:");
              }
              foreach(int i in intArray)
              {
                  Console.WriteLine("" + i);
                  Console.WriteLine("");
                  Console.WriteLine("for-each loop:");
              }
              int j = 0;
              while(j< intArray.Length)
              {

                  Console.WriteLine(" " + intArray[j]);
                  j++;

              }
              Console.WriteLine("");
              Console.WriteLine("DO_while loop:");
              // using do while loop
              int k = 0;
              do
              {
                  Console.WriteLine("" + intArray[k]);
                  k++;
              } while (k < intArray.Length);

          }*/

        /*2.
         public static void Main()
           {
               int[,] intarray = new int[,]
               {
                   {1,2 },{3,4 },{5,6 },{ 7,8}
               };
               int[,] intarray_d = new int[4,2]
              {
                   {1,2 },{3,4 },{5,6 },{ 7,8}
              };
               // similar elements arrays
               string[,] str = new string[4, 2]{
                   {"one","two" }, {"three","four" },
                   {"five","six "}, {"two" ,"three" }
                   };
               int[,,] intarray3D = new int[,,]{
                {1,2,3 },{3,4,5 },{5,6,7 },{ 7,8,9}
               };
               Console.WriteLine("2DArray[1][1](other):" + intarray_d[1, 1]);
               Console.WriteLine("2DArray[1][0](other):" + intarray_d[1, 0]);


           }*/
        /*3.

       public static void Main(string[] args) 
           {
               int[][] arr = new int[2][];
               arr[0] = new int[5] { 1, 3, 4, 5, 6 };
               arr[1] = new int[4] { 1, 2,4,5};
               int[][] arr1 =
               {
                   new int []{1,4,5,3,5,5 }, new int []{1,4,5,3,5,5 },
               };
               for(int i=0; i < arr.Length; i++)
               {
                   Console.WriteLine("element [" + i + "]Array:");
                   for (int j = 0;j < arr.Length;j++)
                   {
                       Console.WriteLine(arr[i][j] + "");
                       Console.WriteLine();
                   }

               }
           }

           */
        

}