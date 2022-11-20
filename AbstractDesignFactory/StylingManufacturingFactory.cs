namespace AbstractDesignFactory
{
    public abstract class StylingManufacturingFactory
    {
        public abstract IProduct GetProduct(string productType);
        public static StylingManufacturingFactory CreateStylingFactory(string factoryType)
        {
            if (factoryType.Equals("Men"))
                return new MenStylingFactory();
            else
                return new WomenStylingFactory();
        }
    }
}
