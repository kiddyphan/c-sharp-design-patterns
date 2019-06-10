using System.Collections.Generic;

namespace Observer
{
    public class WebClient : ISubject
    {
        private List<IObserver> _users = new List<IObserver>();
        private string _news = "123";

        public void Attach(IObserver user)
        {
            _users.Add(user);
        }

        public void Detach(IObserver user)
        {
            _users.Remove(user);
        }

        public void NotifyByEmail(string news)
        {
            _news = news;
            Notify();
        }
        
        public void Notify()
        {
            foreach (var user in _users)
            {
                user.Update(_news);
            }
        }
    }
}