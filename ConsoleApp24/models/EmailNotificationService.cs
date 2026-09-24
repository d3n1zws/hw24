using ConsoleApp24.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24.models;

public class EmailNotificationService : INotificationService
{
    public async Task NotifyAsync(string message)
    {
        Console.WriteLine($"Email sent: {message}");
        await Task.CompletedTask;
    }
}
