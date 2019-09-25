using CSharp8Features.Demos;
using System;
using System.Threading.Tasks;

namespace CSharp8Features
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // NOTE: Comment / Uncomment demoes as desired

            await AsyncIterators.Demo();

            DefaultInterfaceMembers.Demo();

            IndicesAndRanges.Demo1();
            IndicesAndRanges.Demo2();
            IndicesAndRanges.Demo3();
            IndicesAndRanges.Demo4();
            IndicesAndRanges.Demo5();

            NullableTypes.Demo();

            Patterns.Demo1();
            Patterns.Demo2();

            ReadOnlyMembers.Demo1();
            ReadOnlyMembers.Demo2();

            StaticLocalFunctions.Demo1();
            StaticLocalFunctions.Demo2();

            SwitchExpressions.Demo();

            UsingStatement.Demo1();
            UsingStatement.Demo2();

            Console.ReadKey();

            await Task.CompletedTask;
        }
    }
}
