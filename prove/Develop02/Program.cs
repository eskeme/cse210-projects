using System;
using System.Collections.Generic;
using System.IO;

namespace Journal
{
    class Journal
    {
        private List<Entry> entries = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        public void DisplayEntries()
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine("Date: " + entry.Date);
                Console.WriteLine("Prompt: " + entry.Prompt);
                Console.WriteLine("Entry: " + entry.Text);
                Console.WriteLine();
            }
        }

        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine(entry.Date + "|" + entry.Prompt + "|" + entry.Text);
                }
            }
        }

        public void LoadFromFile(string fileName)
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] fields = reader.ReadLine().Split('|');
                    Entry entry = new Entry(fields[0], fields[1], fields[2]);
                    entries.Add(entry);
                }
            }
        }
    }

    class Entry
    {
        public string Date { get; }
        public string Prompt { get; }
        public string Text { get; }

        public Entry(string date, string prompt, string text)
        {
            Date = date;
            Prompt = prompt;
            Text = text;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            List<string> prompts = new List<string>()
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Quit");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Prompt: " + prompts[new Random().Next(prompts.Count)]);
                        Console.Write("Entry: ");
                        string text = Console.ReadLine();
                        Entry entry = new Entry(DateTime.Now.ToString(), prompts[prompts.Count - 1], text);
                        journal.AddEntry(entry);
                        Console.WriteLine("Entry saved.");
                        Console.WriteLine();
                        break;

                    case 2:
                        journal.DisplayEntries();
                        break;

                    case 3:
                        Console.Write("Enter file name: ");
                        string saveFileName = Console.ReadLine();
                        journal.SaveToFile(saveFileName);
                        Console.WriteLine("Journal saved to file.");
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Write("Enter file name: ");
                        string loadFileName = Console.ReadLine();
                        journal.LoadFromFile(loadFileName);
                        Console.WriteLine("Journal loaded from file.");
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
