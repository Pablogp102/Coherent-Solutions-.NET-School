using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] originalArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            originalArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Original array: [" + string.Join(", ", originalArray) + "]");

        int[] uniqueArray = GetUniqueArray(originalArray, n);

        Console.WriteLine("New array with unique values: [" + string.Join(", ", uniqueArray) + "]");
    }

    static int[] GetUniqueArray(int[] originalArray, int originalLength)
    {
        int[] tempArray = new int[originalLength];
        int uniqueCount = 0;

        for (int i = 0; i < originalLength; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < uniqueCount; j++)
            {
                if (originalArray[i] == tempArray[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                tempArray[uniqueCount] = originalArray[i];
                uniqueCount++;
            }
        }

        int[] uniqueArray = new int[uniqueCount];
        for (int i = 0; i < uniqueCount; i++)
        {
            uniqueArray[i] = tempArray[i];
        }

        return uniqueArray;
    }
}
