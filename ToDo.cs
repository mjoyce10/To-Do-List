using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class ToDo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Category { get; set; }
        public int UrgencyLevel { get; set; }

        public ToDo()
        {

        }

        public ToDo(string title, string description,  string category, string dueDate, int urgencyLevel)
        {
            Title = title;
            Description = description;
            Category = category;
            DueDate = dueDate;
            UrgencyLevel = urgencyLevel;
        }


        

    }
}
