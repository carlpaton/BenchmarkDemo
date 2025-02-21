using System.Diagnostics;

namespace BenchmarkDemo;

public class StopwatchExample
{
    public async Task MyMethod()
    {
        var sw = Stopwatch.StartNew();
        try
        {
            await UnitOfWorkAsync();
        }
        finally
        {
            sw.Stop();
            Console.WriteLine($"MyMethod took {sw.ElapsedMilliseconds}ms ({sw.Elapsed})ts");
            // Elapsed is a timespace, that would be more accurate
        }
    }

    private async Task UnitOfWorkAsync() 
    {
        var minValue = 15;
        var maxValue = 100;
        await Task.Delay(Random.Shared.Next(minValue, maxValue));
    }
}
