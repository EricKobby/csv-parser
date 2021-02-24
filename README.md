# csv-parser
A library to deserialize csv files to a specific type.

# returns
``` csharp
IEnumerable<T>
```
# usage:
``` csharp
 var departments = CsvParser.Deserialize<department>("test.csv");
```
