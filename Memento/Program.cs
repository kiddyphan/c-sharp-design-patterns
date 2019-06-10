using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            editor.Type("One");
            editor.Type(" Two");
            
            editor.Save();
            
            editor.Type(" Three");

            Console.WriteLine(editor.Content);
            
            editor.Restore();

            Console.WriteLine("===========");

            Console.WriteLine(editor.Content);
        }
    }
}