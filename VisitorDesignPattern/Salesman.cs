using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class Salesman:IVisitor
    {
        public string Name { get; set; }

        public Salesman(string name)
        {
            Name = name;
        }

        public void Visit(IElement element)
        {
            SchoolKids kid = (SchoolKids)element;
            Console.WriteLine("Salesman: " + this.Name + " gave the school bag to the child: "
                            + kid.KidName);
        }
    }
}
