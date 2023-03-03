using System;
using System.Runtime.InteropServices;

class main
{
    static void Main()
    {
        SendMessage("Hello, how are you?", "John");

        SendMessage("Meeting postponed", "All employees", true);

        SendMessage("Reminder: project due in 2 days", "Project team", scheduledTime: DateTime.Now.AddDays(2));
    }


    public static void SendMessage(string message, string recipient, [Optional] bool isUrgent, [Optional] DateTime? scheduledTime)
    {
        string urgent = "URGENT!";

        if (isUrgent)
        {
            Console.WriteLine($"[{urgent}] To: {recipient}. Message: {message}");
        }
        else
        {
            Console.WriteLine($"To: {recipient}. Message: {message}");
        }

        if (scheduledTime.HasValue)
        {
            Console.WriteLine($"Message scheduled to send: {scheduledTime.Value}. To: {recipient} Message: {message}");
        }
        else
        {
            Console.WriteLine($"Message was sent immediately. To: {recipient} Message: {message}");
        }
    }


}


