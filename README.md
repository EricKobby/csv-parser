# csv-parser
A library to deserialize csv file to a specific type.

# returns
``` csharp
IEnumerable<T>
```
# usage:
```
Install-Package Csv.Parser -Version 1.0.0
```
``` csharp
 var departments = CsvParser.Deserialize<department>("test.csv");
```
