using System;
using System.Collections.Generic;

namespace CSharp8Features.Demos
{
    public static class NullCoalescingAssignment
    {
        public static void Demo()
        {
            List<int>? numbers = null;
            int? i = null;

            // if numbers = null then default to new List<int>
            numbers ??= new List<int>();

            // Add i to numbers, but if it is null default to 17
            numbers.Add(i ??= 17);

            // Add i to numbers, but if it is null default to 17
            numbers.Add(i ??= 20);

            Console.WriteLine(string.Join(' ', numbers));
            Console.WriteLine(i);
        }
    }
}
