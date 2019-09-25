using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Features.Demos
{
    public static class SwitchExpressions
    {
        public static void Demo()
        {
            Console.WriteLine($"{nameof(Status.Open)} status is '{GetDispayStatus(Status.Open)}'");
            Console.WriteLine($"{nameof(Status.Closed)} status is '{GetDispayStatus(Status.Closed)}'");
            Console.WriteLine($"{nameof(Status.Overdue)} status is '{GetDispayStatus(Status.Overdue)}'");
        }

        // Nice simple way to replace writing many if-then-else checks
        public static string GetDispayStatus(Status status) => status switch
        {
            Status.Open => "Open All Day",
            Status.Closed => "Closed for the night",
            Status.Overdue => "Overdue - pay now",
            _ => throw new ApplicationException("Unhandled status")
        };
    }

    public enum Status
    {
        Open,
        Closed,
        Overdue
    }
}
