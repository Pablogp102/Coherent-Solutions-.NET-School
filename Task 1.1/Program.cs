using System;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number a:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number b:");
        int b = int.Parse(Console.ReadLine());

        if(a <= b)
        {
            for (int i = a; i <= b; i++)
            {
            ProcessNumber(i);
            }
        }
        else
        {
            for(int i = a; i >= b; i--)
            {
                ProcessNumber(i);
            }
        }
    }


    static void ProcessNumber(int number) 
    { 
        string duodecimal = ConvertToDuodecimal(number);
        int countA = CountCharacter(duodecimal, 'A');

        if(countA == 2)
        {
            Console.WriteLine(number);
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

        bool isNegative = number < 0;
        number = Math.Abs(number);
        string result = "";

        while (number > 0)
        {
            int remainder = number % 12;
            result = (remainder < 10 ? remainder.ToString() : ((char)('A' + remainder - 10)).ToString()) + result;
            number /= 12;
        }

        return isNegative ? "-" + result : result;
    }


}