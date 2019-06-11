using System;

namespace State
{
    public class UpperCaseState : IState
    {
        public void Write(string text)
        {
            Console.WriteLine(text.ToUpper());
        }
    }
}