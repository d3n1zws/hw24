using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24.interfaces;

public interface INotificationService
{
    Task NotifyAsync(string message);
}
