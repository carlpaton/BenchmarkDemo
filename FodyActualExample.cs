using MethodTimer;

namespace BenchmarkDemo
{
    public class FodyActualExample
    {
        [Time]
        public void DemoUseDict(Dictionary<int, DemoClass> dict)
        {
            var s = "";
            for (int i = 0; i < 5000; i++)
            {
                s = dict[i].Name;
            }
        }

        [Time]
        public void DemoUseLinq(List<DemoClass> collection)
        {
            var s = "";
            for (int i = 0; i < 5000; i++)
            {
                s = collection.FirstOrDefault(x => x.Id == i).Name;
            }
        }
    }

    public class DemoClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}