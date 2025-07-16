// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System;

namespace ToDo
{
    class List
    {
        static void Main(string[] args)
        {
            var manager = new Gestor();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Tasks manager ---");
                Console.WriteLine("1. Add task");
                Console.WriteLine("2. Watch task");
                Console.WriteLine("3. Complete task");
                Console.WriteLine("4. Delete task");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Task description");
                        string description = Console.ReadLine();
                        manager.AddTask(description);
                        break;
                    case "2":
                        manager.TaskList();
                        break;
                    case "3":
                        Console.WriteLine("Task to complete ID");
                        if (int.TryParse(Console.ReadLine(), out int idComplete))
                            manager.CompleteTask(idComplete);
                        else
                            Console.WriteLine("Task not found, invalid ID");
                        break;
                    case "4":
                        Console.WriteLine("Task to delete, ID");
                        if (!int.TryParse(Console.ReadLine(), out int idDetele))
                            manager.DeleteTask(idDetele);
                        else
                            Console.WriteLine("Task not found, invalid ID");
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }

            }
            Console.WriteLine("See you next time!");
        }
    }
}