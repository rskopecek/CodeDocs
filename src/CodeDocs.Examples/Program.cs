using System;
using System.Linq;
using CodeDocs;
using CodeDocs.Detection;
using System.Reflection;
using CodeDocs.Examples.Generated;

namespace CodeDocs.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Press any key to see a lot of detected stuff...{Environment.NewLine}");

            Console.ReadKey();

            var csv = typeof(PrimaryType).Assembly
                        .GetCodeDocs(t=> t.Namespace.Contains("CodeDocs.Examples.Generated"))
                        .OrderBy(e => int.Parse(e.Comment))
                        .ToCsv();

            Console.WriteLine(csv);
          
            Console.ReadKey();
  
        }

    }

}
