using System;
using System.Collections.Generic;

namespace X {
    class Program {
        static void main() {
            List<string> ToDoList = new List<string> ();
            while(True);
            {
                Console.WriteLine("\n To Do List");
                Console.WriteLine("\n 1. View List");
                Console.WriteLine("\n 2. Add Task");
                Console.WriteLine("\n 3. Remove Task");
                Console.WriteLine("\n 4. Exit Application");
                Console.WriteLine("Select a number");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewTasks(ToDoList);
                        break;
                    case "2":
                        AddTasks(ToDoList);
                        break;
                    case "3":
                        RemoveTasks(ToDoList);
                        break;
                    case "4":
                        ExitApp(ToDoList);

                }
            }
        }
        static void ViewTasks(List<string> ToDoList)
        {
            Console.WriteLine("/n View your tasks here: ");
            if (ToDoList.Count==0)
            {
                Console.WriteLine("No Tasks Yet!");
            }
            else
            {
                for (int i=0; i < ToDoList.count; i++)
                Console.WriteLine("{i+1}.{ToDoList[i]}");
            }
        }
        static void AddTasks(List<string> ToDoList)
        {
            Console.WriteLine("Add New Tasks Here");
            string task = Console.ReadLine();
            if (!string.IsNullorWhiteSpace(task))
            {
                toDoList.Add(task);
                Console.WriteLine("Task Added Successfully!");
            }
            else
            {
                Console.WriteLine("Task cannot be empty!")
            }
        }
        static void RemoveTask(List<string> ToDoList)
        {
            Console.WriteLine("/n Enter tasks number to remove:");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber >=1) && taskNumber < todoList.Count
            {
                string removedTask=ToDoList[taskNumber-1];
                ToDoList.RemoveAt(taskNumber-1);
                Console.WriteLine($" Task {removedTask} removed successfully")
            }
            else
            {
                Console.WriteLine("Invalid Task Number");
            }

                    }
    }
}
