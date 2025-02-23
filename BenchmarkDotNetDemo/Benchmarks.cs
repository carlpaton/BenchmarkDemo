using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNetDemo;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private readonly List<int> _rawNumber;

    public Benchmarks()
    {
        _rawNumber = Enumerable.Range(1, 1000).ToList();
    }

    [Benchmark]
    public int FindRaw() 
    { 
        return _rawNumber.Find(x => x > 500);
    }

    [Benchmark]
    public int FirstOrDefaultRaw()
    {
        return _rawNumber.FirstOrDefault(x => x > 500);
    }
}
