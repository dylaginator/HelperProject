using WespBasReportingDesktop.ExtensionMethods;

namespace csvToClass;

public class GenerateInMemoryClass
{
    public static void GenerateInMemoryClassFromModel()
    {
        string code = "public class InMemoryDataContainer  \n { \n";

        var filePaths =
            Directory.GetFiles(
                @"L:\WESP\Projects\WespBasReportingDesktop\WespBasReportingDesktop\Models\WespDataModels");
        var csFilePaths = filePaths.Select(path =>
        {
            if (path.EndsWith(".cs"))
                return path;
            return null;
        }).Where(path => path is not null).ToArray();

        foreach (var path in csFilePaths)
        {
            var fileName = Path.GetFileNameWithoutExtension(path);

            code +=
                $"\t public Dictionary<string,{fileName.ToTitleCase()}> {fileName} " +
                "{ get; private set; } = new (); \n";
        }

        code += "}\n";

        File.WriteAllText($@"L:\WESP\Projects\WespBasReportingDesktop\WespBasReportingDesktop\Models\InMemoryDataContainer.cs", code);

        Console.Write(code);
    }
}