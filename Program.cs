using CSharp8Features.Demos;
using System;
using System.Threading.Tasks;

namespace CSharp8Features
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //NullableTypes.Demo();
            //await AsyncIterators.Demo();
            //SwitchExpressions.Demo();
            //Patterns.Demo1();
            //Patterns.Demo2();
            //UsingStatement.Demo1();
            //UsingStatement.Demo2();
            //StaticLocalFunctions.Demo1();
            //StaticLocalFunctions.Demo2();

            // DM TODO: Double check all demos are here

            Console.ReadKey();

            await Task.CompletedTask;
        }
    }
}
