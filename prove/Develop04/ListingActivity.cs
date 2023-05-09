using System;
using System.Threading;

class ListingActivity : BaseActivity {
    public string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    public string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void RunActivity() {
        Console.WriteLine(description);

        var prompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(2000);

        Console.Write("Enter duration of activity (in seconds): ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready to start listing...");
        Thread.Sleep(3000);

        var startTime = DateTime.Now;
        var count = 0;
        while ((DateTime.Now - startTime).TotalSeconds < duration) {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items.");
        EndActivity((DateTime.Now - startTime).TotalSeconds);
    }
}
