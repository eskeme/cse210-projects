public class BreathingActivity : BaseActivity
{
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public override void RunActivity()
    {
        Console.WriteLine(GetDescription());
        string[] breaths = { "Breathe in...", "Breathe out..." };
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            foreach (var breath in breaths)
            {
                Console.WriteLine(breath);
                for (int i = 3; i >= 1; i--)
                {
                    Console.Write($"{i}...");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }
        }
        EndActivity((DateTime.Now - startTime).TotalSeconds);
    }
}
