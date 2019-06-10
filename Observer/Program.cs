using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Subject
            var webclient = new WebClient();
            
            // Create Observer
            var user1 = new User("User 1");
            var user2 = new User("User 2");
            var user3 = new User("User 3");
            
            webclient.Attach(user1);
            webclient.Attach(user2);
            webclient.Attach(user3);
            
            webclient.NotifyByEmail("456");
            
            webclient.Detach(user3);

            Console.WriteLine("========");
            
            webclient.NotifyByEmail("789");
            
        }
    }
}