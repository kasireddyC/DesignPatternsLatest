namespace VisitorDesignPattern
{
    public class SchoolKids:IElement
    {
        public string KidName { get; set; }
        public SchoolKids(string name)
        {
            KidName = name;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
