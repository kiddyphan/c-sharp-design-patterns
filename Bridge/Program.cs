using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var excelFormatter = new ExcelFormatter();
            var htmlFormatter = new HTMLFormatter();
            
            var userExport = new UserDatabaseExport(excelFormatter);
            var productExport = new ProductDatabaseExport(htmlFormatter);
            userExport.exportDatabase();
            productExport.exportDatabase();

            Console.WriteLine("===========");
            
            userExport.setNewFormatter(htmlFormatter);
            userExport.exportDatabase();
        }
    }
}