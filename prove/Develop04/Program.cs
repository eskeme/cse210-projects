using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {   
            Console.WriteLine("Hello welcome to the Mindfulness Program.");
            Console.WriteLine();
            Console.WriteLine("Please select an activity by typing the corresponding letters.");
            Console.WriteLine();
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You have selected Breathing Activity.");
                    Console.WriteLine();
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.SetDuration();
                    breathing.RunActivity();
                    break;

                case 2:
                    Console.WriteLine("You have selected Reflection Activity.");
                    Console.WriteLine();
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.SetDuration();
                    reflection.RunActivity();
                    break;

                case 3:
                    Console.WriteLine("You have selected Listing Activity.");
                    Console.WriteLine();
                    ListingActivity listing = new ListingActivity();
                    listing.SetDuration();
                    listing.RunActivity();
                    break;

                case 4:
                    Environment.Exit(0);
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
