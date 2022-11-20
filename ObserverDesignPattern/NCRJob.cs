using System;
using System.Collections.Generic;

namespace ObserverDesignPattern
{
    public class NCRJob : INCRJob
    {
        private List<IJobSeeker> observers = new List<IJobSeeker>();
        private string Role { get; set; }
        private string Designation { get; set; }
        private string Availability { get; set; }
        public NCRJob(string role, string designation, string availability)
        {
            Role = role;
            Designation = designation;
            Availability = availability;
        }

        public string getAvailability()
        {
            return Availability;
        }
        public void setAvailability(string availability)
        {
            if(this.Availability.ToLower() != availability.ToLower())
            {
                this.Availability = availability;
                Console.WriteLine("Job availability changed.");
                NotifyObservers();
            }
            else
            {
                Console.WriteLine("Status not yet updated : "+this.Availability);
            }
        }
        public void RegisterObserver(IJobSeeker observer)
        {
            Console.WriteLine("Job Seeker Added : " + ((JobSeeker)observer).UserName);
            observers.Add(observer);
        }
        public void RemoveObserver(IJobSeeker observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            Console.WriteLine("Role Name :"
                            + Role + "Designation : "
                            + Designation + "Vacancies are there. So notifying all Registered users.");
            Console.WriteLine();
            foreach (IJobSeeker observer in observers)
            {
                observer.update(Availability);
            }
        }
    }
}
