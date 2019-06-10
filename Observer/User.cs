using System;

namespace Observer
{
    public class User : IObserver
    {
        private string _name;
        private string _news = string.Empty;

        public User(string name)
        {
            _name = name;
        }
        public void Update(string news)
        {
            _news = news;
            Console.WriteLine($"{_name}: This is breaking news {_news}");
        }
    }
}