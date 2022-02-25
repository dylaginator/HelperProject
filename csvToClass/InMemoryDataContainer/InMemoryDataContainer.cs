using System.Globalization;
using System.Reflection;
using CsvHelper;
using CsvHelper.Configuration;

namespace WespBasReportingDesktop.Models;

public partial class InMemoryDataContainer
{
    public void ParseFile<T>(string fileName) where T : IWespData
    {
        List<PropertyInfo>? propertiesList = typeof(InMemoryDataContainer).GetProperties().ToList();
        string path = $@"L:\WESP\Data\WESP\Selecties\{fileName}.csv";

        using (var reader = new StreamReader(path))
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = "\t"
            };

            using (var csv = new CsvReader(reader, config))
            {
                var collection = csv.GetRecords<T>().ToList();
                var prop = propertiesList.First(prop => prop.Name == fileName);
                prop.SetValue(this, collection);
            }
        }
    }
}