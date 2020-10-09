using System;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            List myToDoList = new List();
            Console.WriteLine("Hello! Welcome to the To-Do List App.");
            bool usingToDoList = true;
            while (usingToDoList)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. See To-Do List.");
                Console.WriteLine("2. Add a task.");
                Console.WriteLine("3. Complete a task.");
                Console.WriteLine("4. Remove a task.");
                Console.WriteLine("5. Edit an urgency level.");
                Console.WriteLine("6. Exit.");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        myToDoList.PrintList();
                        myToDoList.ShowMoreInfo();
                        break;
                    case "2":
                        myToDoList.AddTask();
                        break;
                    case "3":
                        myToDoList.CompleteTask();
                        break;
                    case "4":
                        myToDoList.RemoveTask();
                        break;
                    case "5":
                        myToDoList.ChangeUrgencyLevel();
                        break;
                    case "6":
                        usingToDoList = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                
                Console.Clear();
            }
        }
    }
}
