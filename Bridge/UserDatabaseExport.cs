using System;

namespace Bridge
{
    public class UserDatabaseExport : IDatabaseExport
    {
        private IFormatter _formatter;

        public UserDatabaseExport(IFormatter formatter)
        {
            this._formatter = formatter;
        }

        public void setNewFormatter(IFormatter formatter)
        {
            this._formatter = formatter;
        }

        public void exportDatabase()
        {
            Console.WriteLine($"User DataBase export to {this._formatter.getFormatter()}");
        }
    }
}