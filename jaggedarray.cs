// C# program to single-dimensional jagged array
// that contains three two-dimensional array
// elements of different sizes.
using System;
namespace NN {

class NNN {

// Main Method
public static void Main()
{
 
    int[][, ] arr = new int[3][, ] {new int[, ] {{1, 3}, {5, 7}},
                                    new int[, ] {{0, 2}, {4, 6}, {8, 10}},
                                    new int[, ] {{11, 22}, {99, 88}, {0, 9}}};
 
    // Display the array elements:
    for (int i = 0; i < arr.Length; i++)
    {
        int x = 0;
        int t;
        for (int j = 0; j < arr[i].GetLength(x); j++)
        {
            //t = arr[i].GetLength(x);
            //Console.WriteLine(t);
            Console.WriteLine("Len" + (arr[i].GetLength(x)));
            //arr[i].GetLength(x)
            for (int k = 0; k < arr[j].Rank; k++)
                Console.Write(" arr[" + i + "][" + j + ", " + k + "]:"
                                            + arr[i][j, k] + " ");
            Console.WriteLine();
            int s = arr[j].Rank;
            Console.WriteLine(s);
        }
        x++;
        Console.WriteLine();
    }
}
}
}