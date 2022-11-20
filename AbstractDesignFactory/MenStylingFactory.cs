namespace AbstractDesignFactory
{
    public class MenStylingFactory:StylingManufacturingFactory
    {
        public override IProduct GetProduct(string productType)
        {
            if (productType.Equals("Traditional"))
            {
                return new Traditional();
            }
            else if (productType.Equals("Westren"))
            {
                return new Westren();
            }
            else if (productType.Equals("Shoe"))
            {
                return new Shoes();
            }
            else
                return null;
        }
    }
}
