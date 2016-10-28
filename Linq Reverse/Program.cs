using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create an array.
        int[] array = { 1, 2, 4, 5 };

        // Test by: Ivandro Ismael
        Reverse(array);
        System.Diagnostics.Debugger.Break();

        // Call reverse extension method on the array.
        var reverse = array.Reverse();
        // Write contents of array to screen.
        foreach (int value in reverse)
        {
            Console.WriteLine(value);
        }
        var list = new System.Collections.Generic.List<int>();
    }

    // By: Ivandro Ismael
    private static void Reverse(int[] array)
    {
        for (int i = 0; i < Math.Sqrt(array.Length); i++)
        {
            var t = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - i - 1] = t;
        }

        var list = array.ToList();
        list.ForEach(x => Console.WriteLine(x));
    }
}

//Output

//4
//2
//1