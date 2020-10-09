using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class List
    {
        public List<ToDo> ToDoList = new List<ToDo>();

        public void AddTask()
        {
            Console.Clear();
            Console.WriteLine("Please enter a title for your task.");
            string title = Console.ReadLine();
            Console.WriteLine("\nPlease enter a description for your task.");
            string description = Console.ReadLine();
            string category = ChooseACategory();
            Console.WriteLine("\nPlease enter the due date using the following format: MM/DD/YY.");
            string dueDate = Console.ReadLine();
            Console.WriteLine("\nPlease enter an urgency level from 1 to 5, 1 = not urgent, 5 = very urgent.");
            int urgencyLevel = Convert.ToInt32(Console.ReadLine());
            ToDo toDo = new ToDo(title, description, category, dueDate, urgencyLevel);
            ToDoList.Add(toDo);
        }

        public void PrintList()
        {
            Console.Clear();
            int index = 1;
            foreach (ToDo toDo in ToDoList)
            {
                Console.WriteLine($"{index}. {toDo.Title}");
                index++;
            }
        }

        public void ShowMoreInfo()
        {
            bool seeMoreInfo = true;
            while (seeMoreInfo)
            {
                Console.WriteLine("\nEnter the number of the task you would like to see the details of.");
                Console.WriteLine("Enter 0 to return to the main menu.");
                int taskChoice = Convert.ToInt32(Console.ReadLine());
                if (taskChoice == 0)
                    seeMoreInfo = false;
                else
                {
                    ToDo task = ToDoList[taskChoice - 1];
                    Console.WriteLine($"\nTitle: {task.Title}");
                    Console.WriteLine($"Description: {task.Description}");
                    Console.WriteLine($"Category: {task.Category}");
                    Console.WriteLine($"Due Date: {task.DueDate}");
                    Console.WriteLine($"Urgency Level: {task.UrgencyLevel}");
                    Console.WriteLine();
                }
            }
        }

        public void RemoveTask()
        {
            PrintList();
            Console.WriteLine("Please enter the number of the task you want to remove.");
            int removedTask = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"{ToDoList[removedTask].Title} has been removed from the list.");
            ToDoList.RemoveAt(removedTask);
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        public void CompleteTask()
        {
            PrintList();
            Console.WriteLine("Please enter the number of the task you completed.");
            int completedTask = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"Congratulations on completing {ToDoList[completedTask].Title}! It has been removed from the list.");
            ToDoList.RemoveAt(completedTask);
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        public void ChangeUrgencyLevel()
        {
            PrintList();
            Console.WriteLine("\nPlease enter the number of a task to edit its urgency level.");
            int urgencyLevelEditChoice = Convert.ToInt32(Console.ReadLine());
            ToDo editUrgencyToDo = ToDoList[urgencyLevelEditChoice - 1];
            Console.WriteLine($"\nWhat would you like to change {editUrgencyToDo.Title}'s urgency level to?");
            editUrgencyToDo.UrgencyLevel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nYou have successfully changed {editUrgencyToDo.Title}'s urgency level to {editUrgencyToDo.UrgencyLevel}.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public string ChooseACategory()
        {
            Console.WriteLine("\nPlease select a category for your task by entering a number below.");
            Console.WriteLine("\n1. Errands");
            Console.WriteLine("2. Emails/Phone Calls");
            Console.WriteLine("3. School");
            Console.WriteLine("4. Work");
            Console.WriteLine("5. Finance");
            Console.WriteLine("6. Health");
            Console.WriteLine("7. Miscellaneous");
            string categoryChoice = Console.ReadLine();

            switch (categoryChoice)
            {
                case "1":
                    return "Errands";
                case "2":
                    return "Emails/Phone Calls";
                case "3":
                    return "School";
                case "4":
                    return "Work";
                case "5":
                    return "Finance";
                case "6":
                    return "Health";
                case "7":
                    return "Miscellaneous";
                default:
                    return "N/A";
            }
        }

    }
}
