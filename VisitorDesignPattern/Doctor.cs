﻿using System;

namespace VisitorDesignPattern
{
    public class Doctor:IVisitor
    {
        public string Name { get; set; }

        public Doctor(string name)
        {
            Name = name;
        }

        public void Visit(IElement element)
        {
            SchoolKids kid = (SchoolKids)element;
            Console.WriteLine("Doctor: " + this.Name + " did the health checkup of the child: " + kid.KidName);
        }
    }
}
