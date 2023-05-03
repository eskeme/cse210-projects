using System;
using System.Collections.Generic;

namespace ScriptureMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new scripture and display it
            var scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
            DisplayScripture(scripture);

            // Hide words from the scripture until all words are hidden or the user types "quit"
            var hiddenWords = new List<Word>();
            while (hiddenWords.Count < scripture.WordCount)
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit the program.");
                var input = Console.ReadLine().ToLower();
                if (input == "quit")
                {
                    break;
                }
                else
                {
                    var word = scripture.HideRandomWord(hiddenWords);
                    hiddenWords.Add(word);
                    DisplayScripture(scripture, hiddenWords);
                }
            }

            // Display the complete scripture again before exiting
            Console.WriteLine();
            Console.WriteLine("Final Scripture:");
            DisplayScripture(scripture);
        }

        static void DisplayScripture(Scripture scripture, List<Word> hiddenWords = null)
        {
            Console.Clear();
            Console.WriteLine(scripture.Reference);
            Console.WriteLine();

            foreach (var verse in scripture.Verses)
            {
                foreach (var word in verse.Words)
                {
                    if (hiddenWords != null && hiddenWords.Contains(word))
                    {
                        Console.Write("____ ");
                    }
                    else
                    {
                        Console.Write(word.Text + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    class Scripture
    {
        public string Reference { get; }
        public List<Verse> Verses { get; }
        public int WordCount { get; }

        public Scripture(string reference, string text)
        {
            Reference = reference;
            Verses = new List<Verse>();
            var verseTexts = text.Split(';'); // split the text into verses, assuming semicolon as the separator
            foreach (var verseText in verseTexts)
            {
                Verses.Add(new Verse(verseText));
            }
            WordCount = GetWordCount();
        }

        int GetWordCount()
        {
            var count = 0;
            foreach (var verse in Verses)
            {
                count += verse.Words.Count;
            }
            return count;
        }

        public Word HideRandomWord(List<Word> excludedWords)
        {
            var random = new Random();
            Word word;
            do
            {
                var verseIndex = random.Next(Verses.Count);
                var verse = Verses[verseIndex];
                var wordIndex = random.Next(verse.Words.Count);
                word = verse.Words[wordIndex];
            } while (excludedWords.Contains(word));
            return word;
        }
    }

    class Verse
    {
        public List<Word> Words { get; }

        public Verse(string text)
        {
            Words = new List<Word>();
            var wordTexts = text.Split(' '); // split the text into words, assuming space as the separator
            foreach (var wordText in wordTexts)
            {
                Words.Add(new Word(wordText));
            }
        }
    }

    class Word
    {
        public string Text { get; }

        public Word(string text)
        {
            Text = text;
        }
    }
}
