using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeDocs.Generator.Models;

namespace CodeDocs.Generator.Tests
{
    public static class TestGenerator
    {

        public static void Process(Glossary glossary)
        {
            CompilableAttributeUsageGenerator.Process(glossary);
        }

    }
}
