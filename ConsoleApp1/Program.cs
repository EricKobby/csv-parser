using Csv.Parser;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var departments = CsvParser.Deserialize<department>("test.csv").ToList();
            //foreach (var dept in departments)
            //{
            //    Console.WriteLine(dept.departmentName);
            //}
            Console.ReadKey();
        }
    }

    class department
    {
        public int departmentId { get; set; }
        public string departmentName { get; set; }
        public int headEmployeeId { get; set; }
        public string departmentCode { get; set; }
        public int divisionId { get; set; }
    }
}
