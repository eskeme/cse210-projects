using System;

namespace assignment_week4
{
    public class MathAssignment : Assignment
    {
        private string _textbookSection = "";
        private string _problems = "";

        public string GetTextBookSection()
        {
            return _textbookSection;
        }

        public void SetTextBookSection(string textbooksection)
        {
            _textbookSection = textbooksection;
        }

        public string GetProblems()
        {
            return _problems;
        }

        public void SetProblems(string problems)
        {
            _problems = problems;
        }

        public string GetHomeworkList()
        {
            return $"\n{_studentName} - {_topic}\n{_textbookSection} {_problems}";
        }
    }
}