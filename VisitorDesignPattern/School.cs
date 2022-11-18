using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class School
    {
        private static List<IElement> elements;
        static School()
        {
            elements = new List<IElement>
            {
                new SchoolKids("Ram"),
                new SchoolKids("Gopi"),
                new SchoolKids("Sheha")
            };
        }
        public void PerformOperation(IVisitor visitor)
        {
            foreach (var kid in elements)
            {
                kid.Accept(visitor);
            }
        }
    }
}
