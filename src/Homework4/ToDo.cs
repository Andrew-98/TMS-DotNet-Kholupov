using System;

namespace Homework4
{
    class ToDo
    {
        private readonly string Id = Guid.NewGuid().ToString().ToUpper().Substring(0, 5);
        private readonly DateTime _dateTime = DateTime.Now;
        private ToDoStatus _status = ToDoStatus.Backlog;
        public string Name { get; set; }
        public string Description { get; set; }

        public void SetStatus(ToDoStatus status)
        {
            _status = status;
        }

        public string GetId()
        {
            return Id;
        }

        public void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine(Id);
            Console.WriteLine("-------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Status: {_status}");
            Console.WriteLine($"DateTime: {_dateTime}");
        }
        public ToDoStatus ConvertStatus(string status)
        {
            return status switch
            {
                "Backlog" => ToDoStatus.Backlog,
                "Inprogres" => ToDoStatus.InProgres,
                "Done" => ToDoStatus.Done,
                "Canceled" => ToDoStatus.Canceled,
                _ => ToDoStatus.Unknow,
            };
        }
    }
}
