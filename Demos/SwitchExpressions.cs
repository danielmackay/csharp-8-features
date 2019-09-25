using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Features.Demos
{
    public static class SwitchExpressions
    {
        public static void Demo1()
        {
            Console.WriteLine($"{nameof(Status.Open)} status is '{GetDispayStatus1(Status.Open)}'");
            Console.WriteLine($"{nameof(Status.Closed)} status is '{GetDispayStatus1(Status.Closed)}'");
            Console.WriteLine($"{nameof(Status.Overdue)} status is '{GetDispayStatus1(Status.Overdue)}'");
        }

        public static void Demo2()
        {
            Console.WriteLine($"{nameof(Status.Open)} status is '{GetDispayStatus2(Status.Open, false)}'");
            Console.WriteLine($"{nameof(Status.Closed)} status is '{GetDispayStatus2(Status.Closed, false)}'");
            Console.WriteLine($"{nameof(Status.Overdue)} status is '{GetDispayStatus2(Status.Overdue, true)}'");
            Console.WriteLine($"{nameof(Status.Overdue)} status is '{GetDispayStatus2(Status.Overdue, false)}'");
        }

        // Nice simple way to replace writing many if-then-else checks
        public static string GetDispayStatus1(Status status) => status switch
        {
            Status.Open => "Open All Day",
            Status.Closed => "Closed for the night",
            Status.Overdue => "Overdue - pay now",
            _ => throw new ApplicationException("Unhandled status")
        };

        // Nice simple way to replace writing many if-then-else checks
        public static string GetDispayStatus2(Status status, bool premium) => (status, premium) switch
        {
            (Status.Open, _) => "Open All Day",
            (Status.Closed, _) => "Closed for the night",
            (Status.Overdue, false) => "Overdue - pay now!!!",
            (Status.Overdue, true) => "Overdue - please pay soon",
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
