using System;
using System.Threading;

public class BreathingActivity : BaseActivity
{
    public string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public void RunActivity()
    {
        Console.WriteLine(description);
        string[] breaths = { "Breathe in...", "Breathe out..." };
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            foreach (var breath in breaths)
            {
                Console.WriteLine(breath);
                Thread.Sleep(2000);
            }
        }
        EndActivity((DateTime.Now - startTime).TotalSeconds);
    }
}
