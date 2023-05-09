using System;
using System.Threading;

public class BaseActivity {
    public string name;
    public int duration;

    public void SetDuration() {
        Console.Write("Enter duration of activity (in seconds): ");
        Console.WriteLine();
        duration = int.Parse(Console.ReadLine());
    }

    public void StartActivity() {
        Console.WriteLine($"\nStarting {name} activity...");
        Console.WriteLine($"Duration: {duration} seconds\n");
        Console.WriteLine();
        Thread.Sleep(3000);
    }

    public void EndActivity(double elapsedTime) {
        Console.WriteLine($"\nGreat job! You completed the {name} activity.");
        Console.WriteLine($"Duration: {elapsedTime:F2} seconds\n");
        Console.WriteLine();
        Thread.Sleep(3000);
    }
}