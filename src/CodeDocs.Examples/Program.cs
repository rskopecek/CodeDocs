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

            var docs = typeof(PrimaryType).Assembly.GetCodeDocs()
                    .AllDocs().Flatten().Where(e => int.TryParse(e.Att.Comment, out int r))
                    .OrderBy(e => int.Parse(e.Att.Comment)).ToList();

            foreach(var doc in docs)
                Console.WriteLine($"{string.Format("{0,4}", doc.Att.Comment)}.  {doc.Att.Name}: {doc.Doc.Name}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

    }

}
