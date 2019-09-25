using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Features.Demos
{
    public static class StaticLocalFunctions
    {
        public static void Demo1()
        {
            foreach (var i in Counter1(1, 10)) Console.WriteLine(i);
        }

        public static void Demo2()
        {
            foreach (var i in Counter2(1, 10)) Console.WriteLine(i);
        }

        /// <summary>
        /// Instance local function
        /// </summary>
        private static IEnumerable<int> Counter1(int start, int end)
        {
            if (start >= end) throw new ArgumentOutOfRangeException(nameof(start), "start must be less that end");

            return localCounter();

            IEnumerable<int> localCounter()
            {
                for (int i = start; i < end; i++)
                    yield return i;
            }
        }

        /// <summary>
        /// static local function.  Can be a lot more performant in hot path code
        /// </summary>
        private static IEnumerable<int> Counter2(int start, int end)
        {
            if (start >= end) throw new ArgumentOutOfRangeException(nameof(start), "start must be less that end");

            return localCounter(start, end);

            static IEnumerable<int> localCounter(int start, int end)
            {
                for (int i = start; i < end; i++)
                    yield return i;
            }
        }

    }
}
