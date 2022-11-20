using System;

namespace ObserverDesignPattern
{
    public class JobSeeker : IJobSeeker
    {
        public string UserName { get; set; }
        public JobSeeker(string userName, INCRJob subject)
        {
            UserName = userName;
            subject.RegisterObserver(this);
        }

        public void update(string availabiliy)
        {
            Console.WriteLine("Hello " + UserName + ", new job " + availabiliy + " at NCR.");
        }
    }
}
