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

        int[] uniqueArray = GetUniqueArray(originalArray);

        Console.WriteLine("New array with unique values: [" + string.Join(", ", uniqueArray) + "]");
    }

    static int[] GetUniqueArray(int[] originalArray)
    {
        int[] tempArray = new int[originalArray.Length];
        int uniqueCount = 0;

        for (int i = 0; i < originalArray.Length; i++)
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
        Array.Copy(tempArray, uniqueArray, uniqueCount);

        return uniqueArray;
    }
}
