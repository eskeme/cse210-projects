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
                Thread.Sleep(2000);
            }
        }
        EndActivity((DateTime.Now - startTime).TotalSeconds);
    }
}
