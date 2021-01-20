using System;
using System.Threading.Tasks;
using NBB.Core.Effects;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main()
        {
            await using var interpreter = Interpreter.CreateDefault();
            await interpreter.Interpret(MainEffect);
        }

        static readonly Effect<Unit> MainEffect = 
            Effect.From(() => Console.WriteLine("Hello world"));
    }
}
