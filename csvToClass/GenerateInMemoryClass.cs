using WespBasReportingDesktop.ExtensionMethods;

namespace csvToClass;

public class GenerateInMemoryClass
{
    static string inputFolderPath =
        @"L:\WESP\Projects\csvToClass\csvToClass\csvToClass\WespDataModels";

    static string outputFolderPath = @"L:\WESP\Projects\csvToClass\csvToClass\csvToClass\InMemoryDataContainer";

    public static void GenerateInMemoryClassFromModel()
    {
        string code = "public class InMemoryDataContainer  \n { \n";

        string?[] csvFilePaths = CsvFilePaths();

        foreach (var path in csvFilePaths)
        {
            var fileName = Path.GetFileNameWithoutExtension(path);

            code +=
                $"\t public List<{fileName?.ToTitleCase()}> {fileName} " +
                "{ get; private set; } = new (); \n";
        }

        code += "}\n";

        File.WriteAllText($@"{outputFolderPath}\InMemoryDataContainer.cs", code);

        Console.Write(code);
    }

    public static void GenerateInMemoryClassParser()
    {
        string?[] csvFilePaths = CsvFilePaths();


        string code = "namespace WespBasReportingDesktop.Models; \n" +
                      "public partial class InMemoryDataContainer \n { \n public void HydrateProperties() \n {\n";
        foreach (string path in csvFilePaths)
        {
            string fileName = Path.GetFileNameWithoutExtension(path);
            string className = fileName.ToTitleCase();

            code += $"ParseFile<{className}>(\"{fileName}\"); \n";

        }
            code += "} }";
            File.WriteAllText($@"{outputFolderPath}\InMemoryDataContainerParser.cs", code);
    }

    private static string?[] CsvFilePaths()
        {
            var filePaths =
                Directory.GetFiles(inputFolderPath);
            var csFilePaths = filePaths.Select(path =>
            {
                if (path.EndsWith(".cs"))
                    return path;
                return null;
            }).Where(path => path is not null).ToArray();
            return csFilePaths;
        }
    }