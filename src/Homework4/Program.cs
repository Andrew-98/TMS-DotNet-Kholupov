using System;
using System.Collections.Generic;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            var backlog = new List<ToDo>();
            var inputStop = false;

            InputBacklogList(backlog, inputStop);
            ShowBaklog(backlog);
            ChangeBacklogToDoItemsStatus(backlog, inputStop);
            ShowBaklog(backlog);

            Console.ReadLine();
        }

        private static void InputBacklogList(List<ToDo> backlog, bool inputStop)
        {
            while (!inputStop)
            {
                Console.WriteLine("Enter name and description");
                var todo = new ToDo
                {
                    Name = Console.ReadLine(),
                    Description = Console.ReadLine()
                };

                backlog.Add(todo);

                inputStop = InputStop();
                Console.WriteLine();
            }
        }

        private static void ChangeBacklogToDoItemsStatus(List<ToDo> backlog, bool inputStop)
        {
            while (!inputStop)
            {
                Console.WriteLine("Please enter ToDo Id");
                var userInput = Console.ReadLine();

                foreach (var todo in backlog)
                {
                    if (todo.GetId() == userInput)
                    {
                        Console.WriteLine("Enter new ToDo status");
                        Console.WriteLine("Avalible statuses: InProgres, Done, Canceled");
                        var newStatus = Console.ReadLine();
                        todo.SetStatus(todo.ConvertStatus(newStatus));
                    }
                }

                inputStop = InputStop();
                Console.WriteLine();
            }
        }

        private static void ShowBaklog(List<ToDo> backlog)
        {
            Console.WriteLine("-------");
            foreach (var todo in backlog)
            {
                todo.GetInfo();
            }
            Console.WriteLine("-------");
        }

        private static bool InputStop()
        {
            Console.Write("Stop? Pres Y/y.");
            var key = Console.ReadKey().Key;
            return key == ConsoleKey.Y;
        }
    }
}
