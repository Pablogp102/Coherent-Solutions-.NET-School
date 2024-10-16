using System;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number a:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number b:");
        int b = int.Parse(Console.ReadLine());

        for (int i = a; i <= b; i++)
        {
            string duodecimal = ConvertToDuodecimal(i);

            int countA = CountCharacter(duodecimal, 'A');

            if (countA == 2)
            {
                Console.WriteLine(i);
            }
        }
    }

    static int CountCharacter(string number, char A)
    {
        int counter = 0;
        foreach (char c in number)
        {
            if (c == A)
            {
                counter++;
            }
        }
        return counter;
    }

    static string ConvertToDuodecimal(int number)
    {
        if (number == 0) return "0";

        string result = "";

        while (number > 0)
        {
            int remainder = number % 12;
            result = (remainder < 10 ? remainder.ToString() : ((char)('A' + remainder - 10)).ToString()) + result;
            number /= 12;
        }

        return result == "" ? "0" : result;
    }


}