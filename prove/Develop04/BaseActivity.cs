using System;
using System.Threading;

public class BaseActivity {
    protected string _name = "";
    protected int duration;
    protected string _description = "";

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetDuration() {
        Console.Write("Enter duration of activity (in seconds): ");
        Console.WriteLine();
        duration = int.Parse(Console.ReadLine());
    }

    public virtual void RunActivity() {
        Console.WriteLine($"Starting {_name} activity...");
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration) {
            Thread.Sleep(1000);
        }
        EndActivity((DateTime.Now - startTime).TotalSeconds);
    }

    public void StartActivity() {
        Console.WriteLine($"\nStarting {_name} activity...");
        Console.WriteLine($"Duration: {duration} seconds\n");
        Console.WriteLine();
        Thread.Sleep(3000);
    }

    public void EndActivity(double elapsedTime) {
        Console.WriteLine($"\nGreat job! You completed the {_name} activity.");
        Console.WriteLine($"Duration: {elapsedTime:F2} seconds\n");
        Console.WriteLine();
        Thread.Sleep(3000);
    }
}
