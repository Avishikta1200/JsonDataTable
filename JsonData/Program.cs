using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Collections;
using Ganss.Excel;

namespace JsonDatatable
{
    class program
    {


        static void Main(string[] args)
        {
            string strResultJson = String.Empty;
            strResultJson = System.IO.File.ReadAllText(@"Data.json");

            var objResponse1 =
            JsonConvert.DeserializeObject<List<Student>>(strResultJson);
            var a = objResponse1[0];
            var b = objResponse1[1];
            Console.WriteLine("-------------------------");
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            ExcelMapper mapper = new ExcelMapper();
            var newFile = @"C:\Users\Avishikta\source\repos\JsonData\dataExcel.xlsx";
            mapper.Save(newFile, objResponse1, "SheetName", true);
            Console.ReadKey();
        }
    }
}


