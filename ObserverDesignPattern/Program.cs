using System;

namespace ObserverDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            NCRJob ncrJob = new NCRJob(".NET FULL STACK DEVELOPER\n", "SOFTWARE ENGINEER-II\n", "No vacancies available");

            Console.WriteLine("Current Job Status : " + ncrJob.getAvailability());

            JobSeeker user1 = new JobSeeker("Anurag", ncrJob);
            JobSeeker user2 = new JobSeeker("Pranaya", ncrJob);
            JobSeeker user3 = new JobSeeker("Priyanka", ncrJob);

            Console.WriteLine();
            ncrJob.setAvailability("vacancies available");
            Console.ReadLine();
        }
    }
}
