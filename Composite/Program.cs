using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var label = new Label();
            var input = new Input();
            var text = new Text();
            var form = new Form();
            form.addElement(label);
            form.addElement(input);
            form.addElement(text);

            Console.WriteLine(form.render());
        }
    }
}