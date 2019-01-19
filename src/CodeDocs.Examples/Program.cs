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
                    .AllDocs().Flatten()
                    .OrderBy(e => int.Parse(e.att.Comment)).ToList();

            foreach(var doc in docs)
                Console.WriteLine($"{string.Format("{0,4}", doc.att.Comment)}.  {doc.att.Name}: {doc.doc.Name}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }


}
