using System;
using System.Threading;

public class ListingActivity : BaseActivity {
    public string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() {
        SetName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public override void RunActivity() {
        Console.WriteLine(GetDescription());

        var prompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(2000);

        StartActivity();

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
