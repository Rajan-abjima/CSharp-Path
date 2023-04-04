//using JaggedArrayDemo;
using System;
namespace Arrays
{

    class Array
    {

        public static void Main()
        {
            Console.WriteLine("Arrays =");

            int[][] array = new int[2][];

            array[0] = new int[5] { 1, 3, 5, 7, 9 };
            array[1] = new int[4] { 2, 4, 6, 8 };

            int[][] arr1 = { new int[] { 1, 3, 5, 7, 9 },
                        new int[] { 2, 4, 6, 8 } };

            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write("[" + i + "] Array: ");
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write(array[i][j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine("Jagged Array =");

            int[][] jagged_array = new int[4][];

            jagged_array[0] = new int[] { 1, 2, 3, 4 };
            jagged_array[1] = new int[] { 11, 34, 67 };
            jagged_array[2] = new int[] { 89, 23 };
            jagged_array[3] = new int[] { 0, 45, 78, 53, 99 };

            for (int n = 0; n < jagged_array.Length; n++)
            {

                System.Console.Write("Row({0}): ", n);

                for (int k = 0; k < jagged_array[n].Length; k++)
                {

                    System.Console.Write("{0} ", jagged_array[n][k]);
                }
                System.Console.WriteLine();

            }

            Console.WriteLine("List Example =");

            List<int> firstlist = new List<int>();

            firstlist.Add(17);
            firstlist.Add(19);
            firstlist.Add(21);
            firstlist.Add(9);
            firstlist.Add(75);
            firstlist.Add(19);
            firstlist.Add(73);

            Console.WriteLine("Elements Present in List:\n");

            int p = 0;

            foreach (int k in firstlist)
            {
                Console.Write("At Position {0}: ", p);
                Console.WriteLine(k);
                p++;
            }

            Console.WriteLine(" ");

            Console.WriteLine("Removing the element at index 3\n");

            firstlist.RemoveAt(3);

            int p1 = 0;

            foreach (int n in firstlist)
            {
                Console.Write("At Position {0}: ", p1);
                Console.WriteLine(n);
                p1++;
            }

        }
    }
}

