using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using static System.IO.Directory;

namespace CodeDocs.Generator
{

    public static class Generate
    {


        public static void Examples()
        {
            int counter = 0;

            var nestedType1 = (new ExampleTemplate("struct", "NestedType1", () => (++counter).ToString(), "")).TransformText();
            var nestedType2 = (new ExampleTemplate("class", "NestedType2", () => (++counter).ToString(), nestedType1)).TransformText();
            var primaryType = (new ExampleTemplate("class", "PrimaryType", () => (++counter).ToString(), nestedType2)).TransformText();
            var wrapper = (new ExampleWrapperTemplate(primaryType, counter)).TransformText();

            File.WriteAllText("../CodeDocs.Examples/Generated.cs", wrapper);
        }


        const string workingPath = "../CodeDocs/Generated/";

        public static void CodeDocAttributes()
        {

            Reset();

            GenerateAttributes();

        }


        static void Reset()
        {
            Delete(workingPath, true);

            CreateDirectory(workingPath);
        }

        static void GenerateAttributes()
            => Definition.List.ForEach(GenerateFile);

        static void GenerateFile(Definition definition)
            => File.WriteAllText($"{workingPath}{definition.Name}.generated.cs", GenerateText(definition));

        static string GenerateText(Definition definition)
            => (new CodeDocAttributeTemplate(definition)).TransformText();

    }
}
