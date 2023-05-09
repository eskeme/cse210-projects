using System;

namespace assignment_week4
{
    public class WritingAssignment : Assignment
    {
        private string _title = "";

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }

        public string GetWritingInformation()
        {
            return $"\n{_studentName} - {_topic}\n{_title}";
        }
    }
}