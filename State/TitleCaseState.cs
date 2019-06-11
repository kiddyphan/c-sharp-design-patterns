using System;
using System.Globalization;

namespace State
{
    public class TitleCaseState : IState
    {
        public void Write(string text)
        {
            var textInfo = new CultureInfo("en-US", false).TextInfo;
            
            Console.WriteLine(textInfo.ToTitleCase(text));
        }
    }
}