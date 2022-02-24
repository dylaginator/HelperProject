using System.Text.RegularExpressions;
using WespBasReportingDesktop.ExtensionMethods;

namespace csvToClass;

public class CsvToClass
{
    public static void generateModel()
    {
        var filePaths = Directory.GetFiles(@"L:\WESP\Data\WESP\Selecties");
        var csvFilePaths = filePaths.Select(path =>
        {
            if (path.EndsWith(".csv"))
                return path;
            return null;
        }).Where(path => path is not null).ToArray();

        foreach (var path in csvFilePaths)
        {
            var fileName = Path.GetFileNameWithoutExtension(path);
            try
            {
                var classString = CsvToClass.CSharpClassCodeFromCsvFile(path);
                File.WriteAllText($@"L:\WESP\Data\WESP\Selecties\CsModel\{fileName}.cs", classString);
                Console.WriteLine(fileName);
            }
            catch
            {
                Console.WriteLine($"Failed for {fileName}");
            }
        }
    }

    public static string CSharpClassCodeFromCsvFile(string filePath, string delimiter = "\t",
        string classAttribute = "", string propertyAttribute = "")
    {
        if (string.IsNullOrWhiteSpace(propertyAttribute) == false)
            propertyAttribute += "\n\t";
        if (string.IsNullOrWhiteSpace(propertyAttribute) == false)
            classAttribute += "\n";

        string[] lines = File.ReadAllLines(filePath);
        string[] columnNames = lines.First().Split(delimiter).Select(str => str.Trim()).ToArray();
        string[] data = lines.Skip(1).ToArray();

        string className = Path.GetFileNameWithoutExtension(filePath);
        string classNameTitleCase = className.ToTitleCase();
        // use StringBuilder for better performance
        string code = String.Format("using System; \n {0}public class {1} {{ \n", classAttribute, classNameTitleCase);

        for (int columnIndex = 0; columnIndex < columnNames.Length; columnIndex++)
        {
            var columnName = Regex.Replace(columnNames[columnIndex], @"[\s\.]", string.Empty, RegexOptions.IgnoreCase);
            if (string.IsNullOrEmpty(columnName))
                columnName = "Column" + (columnIndex + 1);
            var variableDeclaration = GetVariableDeclaration(data, columnIndex, columnName, propertyAttribute);
            code += $"\t {variableDeclaration}\n\n";
        }

        code += "}\n";
        return code;
    }

    public static string GetVariableDeclaration(string[] data, int columnIndex, string columnName,
        string attribute = null)
    {
        string[] columnValues = data.Select(line => line.Split('\t')[columnIndex].Trim()).ToArray();
        string typeAsString;

        if (AllDateTimeValues(columnValues))
        {
            typeAsString = "DateTime";
        }
        else if (AllIntValues(columnValues))
        {
            typeAsString = "int";
        }
        else if (AllDoubleValues(columnValues))
        {
            typeAsString = "double";
        }
        else
        {
            typeAsString = "string";
        }

        string declaration = String.Format("{0}public {1} {2} {{ get; set; }}", attribute, typeAsString, columnName);
        return declaration;
    }

    public static bool AllDoubleValues(string[] values)
    {
        double d;
        return values.All(val => double.TryParse(val, out d));
    }

    public static bool AllIntValues(string[] values)
    {
        int d;
        return values.All(val => int.TryParse(val, out d));
    }

    public static bool AllDateTimeValues(string[] values)
    {
        DateTime d;
        return values.All(val => DateTime.TryParse(val, out d));
    }

    // add other types if you need...
}