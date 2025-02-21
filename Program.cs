using BenchmarkDemo;

// --- Simple stopwatch example
//var swe = new StopwatchExample();
//await swe.MyMethod();


// --- Foddy example without additional log data
//await FodyExample.MyMethod();


// --- Foddy example comparing data structure access speed
var dict = new Dictionary<int, DemoClass>();
var collection = new List<DemoClass>();

for (int i = 0; i < 5000; i++)
{
    dict.Add(i, new DemoClass() { Id = i, Name = $"Name{i}" });
    collection.Add(new DemoClass() { Id = i, Name = $"Name{i}" });
}

var eg = new FodyActualExample();
eg.DemoUseDict(dict);
eg.DemoUseLinq(collection);




