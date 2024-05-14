using System.Collections;

namespace Generics_Lab
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList()
            {
                3,
                "teda",
                null,
                string.Empty,
                new List<string>()
            };
            List<object> arrayList2 = new List<object>()
            {
                3,
                "teda",
                null,
                string.Empty,
                new List<string>()
            };
        }
    }
}