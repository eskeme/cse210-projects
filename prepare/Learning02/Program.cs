using System;
using System.Collections.Generic;

public class Job
{
    private string _company;
    private string _jobTitle;
    private int _startYear;
    private int _endYear;

    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

public class Resume
{
    private string _name;
    private List<Job> _jobs;

    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
        Job job2 = new Job("Apple", "Manager", 2022, 2023);

        Resume myResume = new Resume("Allison Rose");
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        myResume.Display();
    }
}
