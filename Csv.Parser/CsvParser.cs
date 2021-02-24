using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Csv.Parser
{
    public sealed class CsvParser
    {
        public static IEnumerable<T> Deserialize<T>(string path)
        {
            var rawData = File.ReadLines(path).ToList();
            var columns = rawData.First().Split(',');
            var rawRows = rawData.Skip(1).ToList();
            var listOfItems = new List<T>();


            for (int j = 0; j < rawRows.Count; j++)
            {
                var currentRow = rawRows[j].Split(',');
                var instance = Activator.CreateInstance<T>();

                for (int k = 0; k < currentRow.Length; k++)
                {
                    var currentProperty = instance.GetType().GetProperty(columns[k]);
                    
                    if (currentProperty is null)continue;

                    var currentPropertyValue = currentRow[k].Trim('"');

                    if (!string.IsNullOrEmpty(currentPropertyValue))
                        currentProperty.SetValue(instance, Convert.ChangeType(currentPropertyValue, currentProperty.PropertyType));
                }
                listOfItems.Add(instance);
            }

            return listOfItems;
        }
    }
}
