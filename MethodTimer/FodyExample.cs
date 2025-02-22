using MethodTimer;
using System.Diagnostics;

namespace BenchmarkDemo;

public class FodyExample
{
    //[Time("message was: '{message}'")]
    //public static async Task MyMethod(int message)
    //{
    //    Trace.WriteLine($"ZZZZ START {message}");
    //    await UnitOfWorkAsync();
    //}

    [Time]
    public static async Task MyMethod()
    {
        Trace.WriteLine($"ZZZZ START no params");
        await UnitOfWorkAsync();
    }

    private static async Task UnitOfWorkAsync()
    {
        var minValue = 15;
        var maxValue = 100;
        await Task.Delay(Random.Shared.Next(minValue, maxValue));
    }
}
