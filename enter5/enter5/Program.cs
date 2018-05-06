using System;

namespace enter5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 unique numbers to be sorted");

            int[] unsortedArray = new int[5];
            unsortedArray[0] = int.Parse(Console.ReadLine());

            for (int i = 1; i < 5; i++)
            {
                unsortedArray[i] = int.Parse(Console.ReadLine());

                // check if unique or error back
                // needs to not apply 1st time
                for(int j = i - 1; j > -1; j--)
                {
                    Console.WriteLine($"Comparing unsortedArray[{i}]: {unsortedArray[i]} with unsortedArray[{j}]: {unsortedArray[j]}");
                    if (unsortedArray[i] == unsortedArray[j])
                    {
                        Console.WriteLine("Error: last number not unique");
                        i--;
                        break;
                    } else
                    {
                        Console.WriteLine("ok");
                    }
                }


            }

            Console.WriteLine("Sort this mess!");
            Array.Sort(unsortedArray);

            foreach (var n in unsortedArray)
                Console.WriteLine(n);

        }
    }
}
