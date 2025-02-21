using System.Diagnostics;
using System.Reflection;

namespace BenchmarkDemo;

public static class MethodTimeLogger
{
    public static void Log(MethodBase methodBase, TimeSpan elapsed, string message)
    {
        try
        {
            Trace.WriteLine($"ZZZZ MethodTimeLogger");
            Trace.WriteLine($"ZZZZ {methodBase.DeclaringType!.Name}.{methodBase.Name} {elapsed}");
            Trace.WriteLine($"ZZZZ message={message}");
        }
        catch (Exception e)
        {
            Trace.WriteLine($"e={e.Message}");
        }
    }
}
