```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5487/22H2/2022Update)
Intel Core i5-4460 CPU 3.20GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
.NET SDK 9.0.103
  [Host]     : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2


```
| Method            | Mean     | Error   | StdDev  | Allocated |
|------------------ |---------:|--------:|--------:|----------:|
| FindRaw           | 423.4 ns | 5.62 ns | 5.25 ns |         - |
| FirstOrDefaultRaw | 172.8 ns | 2.29 ns | 2.14 ns |         - |
