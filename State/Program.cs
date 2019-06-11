using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            editor.Type("In the name of god");
            
            editor.SetState(new UpperCaseState());
            editor.Type("in the name of god");
            
            editor.SetState(new TitleCaseState());
            editor.Type("in the name of god");
        }
    }
}