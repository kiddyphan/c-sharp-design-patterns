using System;

namespace Bridge
{
    public class ProductDatabaseExport : IDatabaseExport
    {
        private IFormatter _formatter;

        public ProductDatabaseExport(IFormatter formatter)
        {
            this._formatter = formatter;
        }

        public void setNewFormatter(IFormatter formatter)
        {
            this._formatter = formatter;
        }

        public void exportDatabase()
        {
            Console.WriteLine($"Product DataBase export to {this._formatter.getFormatter()}");
        }
    }
}