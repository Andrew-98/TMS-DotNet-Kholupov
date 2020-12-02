using System;

namespace Homework7Core.Manager
{
    public static class NotificationManager
    {
        public static void Show(string message, DateTime dateTime)
        {
            Console.WriteLine($"{message} {dateTime}");
        }
    }
}
