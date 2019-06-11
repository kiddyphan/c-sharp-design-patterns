using System;

namespace State
{
    public class NormalCaseState : IState
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}