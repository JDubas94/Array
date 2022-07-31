using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of array elements: ");

            int n = int.Parse(Console.ReadLine());

           int [] newArray = new int[n];

            Console.WriteLine("Enter array elements: ");

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array in reverse order: ");

            for(int w = newArray.Length-1; w >= 0; --w)
            {
                Console.WriteLine(newArray[w]);
            }
            Console.WriteLine();

            int sum = 0;

            for (int u = 0; u < newArray.Length; u++)
            {
                if (newArray[u] % 2 == 0)
                {
                    sum = sum + newArray[u];
                    
                }
            }
            Console.WriteLine("Sum of even numbers: " + sum);

            Console.WriteLine();

            int min = newArray[0];

            for ( int h = 0; h < newArray.Length; h++)
            {
            if (newArray[h] < min)
            {
                    min = newArray[h];
            }
            }

            Console.WriteLine("Min array number:" + min);

            Console.ReadLine();

        }
    }
}
