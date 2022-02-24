using System.IO;
using System.Reflection;

namespace WespBasReportingDesktop.Models;

public partial class InMemoryDataContainer
{
    public static void HydrateProperty(/*IDictionary<string,T> obj, string filePath*/) 
    {
       var fileRows = GetRowsFromFile(@"L:\WESP\Data\WESP\Selecties\Accu_Feitenblok_1.csv");
       var fields = fileRows[0].Split('\t');
       var newEntry = new AccuFeitenblok1();
       var typeProps = typeof(AccuFeitenblok1).GetProperties();
       foreach (var item in typeProps.Select(((info, i) => new {info,i})))
       {
           Console.WriteLine($"{item.info.Name} {fields[item.i]}");
           item.info.SetValue(newEntry,fields[item.i]);
       }
       
       return;
    }


    private static List<string> GetRowsFromFile(string filePath)
    {
        StreamReader streamReader = File.OpenText(filePath);
        streamReader.ReadLine(); //skip the header

        List<string> rows = new();

        while (!streamReader.EndOfStream)
        {
            string row = streamReader.ReadLine();
            if (row is not null)
            {
                rows.Add(row);
            }
        }

        return rows;
    }
}