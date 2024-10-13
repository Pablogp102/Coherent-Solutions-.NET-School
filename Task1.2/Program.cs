using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first 9 digits of the ISBN: ");
        string isbnPart = Console.ReadLine();

        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            int digit = int.Parse(isbnPart[i].ToString());
            sum += (10 - i) * digit;
        }

        int d10 = (11 - (sum % 11)) % 11;

        string checkDigit = d10 == 10 ? "X" : d10.ToString();

        string completeISBN = isbnPart + checkDigit;
        Console.WriteLine("The complete ISBN is: " + completeISBN);
    }
}
