﻿using System;

namespace VisitorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            var visitor1 = new Doctor("Kumar");
            school.PerformOperation(visitor1);
            Console.WriteLine();
            var visitor2 = new Salesman("John");
            school.PerformOperation(visitor2);
            Console.ReadLine();
        }
    }
}
