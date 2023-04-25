using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string valueFromUser = Console.ReadLine();
        int percent = int.Parse(valueFromUser);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        char sign = '\0';
        int lastDigit = percent % 10;
        if (lastDigit >= 7 && letter != "A")
        {
            sign = '+';
        }
        else if (lastDigit < 3 && letter != "F")
        {
            sign = '-';
        }

        if (letter == "A")
        {
            if (percent == 100)
            {
                Console.WriteLine("Your grade is: A+");
            }
            else if (percent >= 97)
            {
                Console.WriteLine("Your grade is: A");
            }
            else
            {
                Console.WriteLine("Your grade is: A-");
            }
        }
        else
        {
            Console.WriteLine($"Your grade is: {letter}{sign}");
        }

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }   
}